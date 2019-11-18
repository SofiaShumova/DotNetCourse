using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//диалог подтверждения перед удалением

//удаление наград

namespace Task01
{


    public partial class MainForm : Form
    {

        public static BindingList<Award> awards;

        public static BindingList<Person> people;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SizeComponents(sender, e);
            ClientSizeChanged += SizeComponents;
            
            CreateDataBase();

            gridPeople.DataSource = people.ToTable();
            gridAwards.DataSource = awards.ToTable();
            
        }

        private void SizeComponents(object sender, EventArgs e)
        {
            tcFullInfo.Width = this.ClientSize.Width;
            tcFullInfo.Height = Convert.ToInt32(this.ClientSize.Height * 0.7);
            tcFullInfo.ItemSize = new Size(Convert.ToInt32(this.ClientSize.Width * 0.3), 50);

            // gridPeople.Width = Convert.ToInt32(tcFullInfo.Width*0.7 - Convert.ToDouble( gridPeople.Location.X));
            gridPeople.Width = Convert.ToInt32((tcFullInfo.Width - Convert.ToInt32(gridPeople.Location.X)) * 0.7);
            gridPeople.Height = Convert.ToInt32(tcFullInfo.Height * 0.9 - Convert.ToDouble(gridPeople.Location.Y)
                - tcFullInfo.ItemSize.Height);

            gridAwards.Width = Convert.ToInt32(tcFullInfo.Width * 0.9 - Convert.ToDouble(gridPeople.Location.X));
            gridAwards.Height = Convert.ToInt32(tcFullInfo.Height * 0.9 - Convert.ToDouble(gridPeople.Location.Y)
                - tcFullInfo.ItemSize.Height);

            tbAwardsInfo.Location = new Point(Convert.ToInt32(gridPeople.Location.X) + gridPeople.Width + 10,
               Convert.ToInt32(gridPeople.Location.Y));

            tbAwardsInfo.Width = Convert.ToInt32((tcFullInfo.Width - Convert.ToInt32(tbAwardsInfo.Location.X)) * 0.8);
            tbAwardsInfo.Height = gridPeople.Height;
        }


        private void CreateDataBase()
        {
            people = new BindingList<Person>();
            awards = new BindingList<Award>();


            awards.Add(new Award("Нобелевская премия"));
            awards.Add(new Award("Оскар"));
            awards.Add(new Award("Премия Тьюринга"));
            awards.Add(new Award("Международная премия по биологии"));

            people.Add(new Person("Sofia", "Shumova", new DateTime(1999, 11, 24)));
            people.Add(new Person("Ivan", "Ivanov", new DateTime(1999, 3, 2)));
        }

        
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.Owner = this;
            form.ShowDialog();
            var u = form.User;
            gridPeople.DataSource = people.ToTable();
            gridAwards.DataSource = awards.ToTable();

            gridPeople.Refresh();
            gridAwards.Refresh();

            gridPeople_CellClick(new object(), new DataGridViewCellEventArgs( 0, gridPeople.CurrentRow.Index));
        }

        private void gridPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbAwardsInfo.Clear();
            int index = e.RowIndex;
            string fullAwards = "";
            if (!(index < 0))
            {
                
                foreach (Award i in people[index].GetAwards())
                {
                    fullAwards += $"\r\n{i.Name}";
                }
                if (fullAwards == "") fullAwards = " None";
                tbAwardsInfo.Text = $"Person: {people[index].FirstName} {people[index].LastName} \r\nAwards:{fullAwards.Trim()}";

            }

        }
    }
}
