using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace Task02
{
    class Track : IDisposable //  в отдельный файл и переименовать 
    {
        protected DirectoryInfo dir;                           //отслеживаемая директория
        protected List<FileInfo> textFiles;                    //все отслеживаемые файлы
        FileSystemWatcher fileSystemWatcher;                 //наблюдатели в каждой директории
        DirectoryInfo directoryBackUp;               //директория бэкапов
        protected List<DirectoryInfo> ArrayDirectoriesBackUp;  //массив директорий бэкапов
        //List<DirectoryInfo> TrackingDirectories;     //массив отслеживаемых директорий

        public Track(string directoryInfo)
        {
            string directoryBU = directoryInfo + " backup"; //"C:\\Users\\Софья\\Documents\\Соня\\test backup";

            if (!Directory.Exists(directoryBU)) // если директории с бэкапами нет
            {
                Directory.CreateDirectory(directoryBU);
            }

            directoryBackUp = new DirectoryInfo(directoryBU);
            ArrayDirectoriesBackUp = new List<DirectoryInfo>(directoryBackUp.EnumerateDirectories());  // директории бэкапов 


            dir = new DirectoryInfo(directoryInfo);   // отслеживаемая директория
                                                      // AppendTrackingDirectories();


            textFiles = new List<FileInfo>(dir.GetFiles("*.txt", SearchOption.AllDirectories)); // инф файлов в заданном каталоге
            AppendTextFiles();

            fileSystemWatcher = new FileSystemWatcher(dir.FullName, "*.txt");
            fileSystemWatcher.IncludeSubdirectories = true;

        }

        
        private void AppendTextFiles()
        {
            for (int i = 0; i < textFiles.Count; i++)
            {
                CopyFileAndCreateDirectory(textFiles[i], textFiles[i].LastWriteTime);

            }
        }
        public void OnTracking()
        {
            Subscribe();
            Thread.Sleep(3000);
        }

        private string GetNameDirectoryBackUpFile(FileInfo i)
        {
            return directoryBackUp.FullName + $"\\{i.Name} {Regex.Replace(i.CreationTime.ToString(), "[. | :]", "-")}";
        }
        private void CopyFileAndCreateDirectory(FileInfo i, DateTime date)
        {

            string pathNewCopy = GetNameDirectoryBackUpFile(i);
            if (!Directory.Exists(pathNewCopy))
            {
                Directory.CreateDirectory(pathNewCopy);
                //return;
            }
            if (!File.Exists(pathNewCopy + "\\" + Regex.Replace(date.ToString(), "[. | :]", "-") + ".txt"))
            {
                File.Copy(i.FullName,
               pathNewCopy + "\\" + Regex.Replace(date.ToString(), "[. | :]", "-") + ".txt");

            }


        }
        private void AddNewVersion(string path)
        {
            foreach (FileInfo i in textFiles)
            {
                if (i.FullName == path)
                {
                    CopyFileAndCreateDirectory(i, DateTime.Now);
                }
            }
        }

        private void AddNewFile(string path)
        {
            textFiles.Add(new FileInfo(path));
            CopyFileAndCreateDirectory(new FileInfo(path), DateTime.Now);
        }

        private void Subscribe()
        {
            fileSystemWatcher.EnableRaisingEvents = true;
            fileSystemWatcher.Changed += DefineEvents;
            fileSystemWatcher.Created += DefineEvents;
            fileSystemWatcher.Deleted += DefineEvents;
            fileSystemWatcher.Renamed += RenameEvents;

            Thread.Sleep(10000);
        }

        private void DefineEvents(object sender, FileSystemEventArgs args)
        {

            switch ((int)args.ChangeType)
            {
                case 4:
                    ChangeMessage(args.Name, "изменен", args.FullPath);
                    AddNewVersion(args.FullPath);
                    break;
                case 2:
                    ChangeMessage(args.Name, "удален", args.FullPath);
                    break;
                case 1:
                    ChangeMessage(args.Name, "создан", args.FullPath);
                    AddNewFile(args.FullPath);
                    break;
            }

        }
        private void RenameEvents(object sender, RenamedEventArgs args)
        {
            ChangeMessage(args.OldName, $"переименован в {args.Name}", args.FullPath);
            AddNewFile(args.FullPath);
        }

        private void ChangeMessage(string name, string change, string path)
        {
            Console.WriteLine($"Файл {name} был {change}! \nРасположение: {path}");
        }

        public void Dispose()
        {
            fileSystemWatcher.Changed -= DefineEvents;
            fileSystemWatcher.Created -= DefineEvents;
            fileSystemWatcher.Deleted -= DefineEvents;
            fileSystemWatcher.Renamed -= RenameEvents;
            fileSystemWatcher.EnableRaisingEvents = false;
            fileSystemWatcher.Dispose();


        }

        public void OnBack()
        {

            Console.WriteLine("Выберите дату отката:");
            List<FileInfo> files = new List<FileInfo>();

            foreach (DirectoryInfo i in ArrayDirectoriesBackUp)
            {
                files.AddRange(i.GetFiles("*.txt"));
            }

            List<string> dateArray = new List<string>();
            List<string> timeArray = new List<string>();
            for (int i = 0; i < files.Count; i++)
            {
                //string str = Regex.Replace(files[i].Name, ".txt", ""), 
                    //dateString = Regex.Match(str, "[0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]").ToString(),
                  //  timeString = str.Substring(11, str.Length - 11);
                string dateString = files[i].LastWriteTime.ToShortDateString();
                if (!HaveDouble(dateArray, dateString))
                {
                    dateArray.Add(dateString);
                }
                
            }

            OutputList(dateArray);
             int number = GetValue(dateArray.Count);
            //int number = 0;
            string date = dateArray[number];

            for (int i = 0; i < files.Count; i++)
            {
                //string str = Regex.Replace(files[i].Name, ".txt", ""),
                //dateString = Regex.Match(str, "[0-9][0-9]-[0-9][0-9]-[0-9][0-9][0-9][0-9]").ToString(),
                //timeString = str.Substring(11, str.Length - 11);
                string dateString = files[i].LastWriteTime.ToShortDateString(),
                    timeString = files[i].LastWriteTime.ToShortTimeString();
                if (dateString == date)
                {
                    if (!HaveDouble(timeArray, timeString))
                    {
                        timeArray.Add(timeString);
                    }
                }


            }
            Console.WriteLine("Выберите время отката:");
            OutputList(timeArray);
            number = GetValue(timeArray.Count);
            string time = timeArray[number];
            RollBack(date, time);

        }

        private void RollBack(string date, string time)
        {

            for(int i = 0; i< textFiles.Count; i++)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(GetNameDirectoryBackUpFile(textFiles[i]));
                if (!directoryInfo.Exists)
                {
                    Console.WriteLine($"Для {textFiles[i]} откаты не найдены");
                    //break;
                }
                else
                {
                    List<FileInfo> files = new List<FileInfo>(directoryInfo.GetFiles("*.txt"));
                    for(int j = 0; j < files.Count; j++)
                    {
                        Console.WriteLine(files[j].FullName);
                    }
                    for (int j = files.Count-1 ; j > -1; j--)
                    {
                        if (files[j].LastWriteTime.ToShortDateString() != date)
                        {
                            files.RemoveAt(j);
                        }
                    }
                    Console.WriteLine($"{textFiles[i].Name} содержит {files.Count}");
                    if(files.Count > 0)
                    {
                        bool state = false;
                        for (int j = 0; j < files.Count; j++)
                        {
                            if (files[j].LastWriteTime.ToShortTimeString() == time)
                            {
                                state = true;
                                ReplaceFile(textFiles[i], files[j]);
                            }
                        }
                        if (!state)
                        {
                            ReplaceFile(textFiles[i], files[0]);
                        }
                    }
                    
                   
                }
                

            }
        }

        private void ReplaceFile(FileInfo old , FileInfo nw)
        {
            //CopyFileAndCreateDirectory(old, DateTime.Now);
            Console.WriteLine($"{old.FullName} заменяется {nw.FullName}");
            // File.Copy(nw.FullName, old.FullName, true);
            CopyFileAndCreateDirectory(old, old.LastWriteTime);
            File.Replace(nw.FullName, old.FullName, null, true);
            CopyFileAndCreateDirectory(old, DateTime.Now);
            // null, true);
        }
        private int GetValue(int max)
        {
            int key = -1;
            while (!(int.TryParse(Console.ReadLine(), out key) && (key >= 0) && (key < max)))
            {
                Console.WriteLine("Повторите ввод:");
            }
            return key;
        }
        private bool HaveDouble(List<string> list, string str)
        {
            bool state = false;
            for (int j = 0; j < list.Count; j++)
            {
                if (list[j] == str)
                {
                    state = true;
                }
            }
            return state;
        }
        private void OutputList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i}. "+list[i]);
            }
        }
        ~Track()
        {
            Dispose();
        }


    }
}
