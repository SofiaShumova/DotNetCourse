using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Department.BLL;
using Entities;

//диалог подтверждения перед удалением

//удаление наград

namespace Task01
{
    

    public partial class MainForm : Form
    {
        PersonsBL people = new PersonsBL();
        AwardsBL awards = new AwardsBL();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SizeComponents(sender, e);
            ClientSizeChanged += SizeComponents;

            UpdateData();
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
        

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tcFullInfo.SelectedIndex == 0)
            {
                AddForm form = new AddForm(true, awards.Awards);
                form.ShowDialog();
                if (form.User != null)
                {
                    people.AddPerson(form.User);
                }
               

            }
            else if (tcFullInfo.SelectedIndex == 1)
            {
                AddForm form = new AddForm(false, awards.Awards);
                form.ShowDialog();
                if (form.Award != null)
                {
                    awards.AddAward(form.Award);
                }
            }
            UpdateData();
        }

        private void gridPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbAwardsInfo.Clear();
            
            
            string fullAwards = "";
            if (!(e.RowIndex < 0))
            {
                int ID = Convert.ToInt32(gridPeople[0, e.RowIndex].Value);
                Person person = people.GetPerson(ID);
                foreach (Award i in person.GetAwards())
                {
                    fullAwards += $"\r\n{i.Name}";
                }
                if (fullAwards == "") fullAwards = " None";
                tbAwardsInfo.Text = $"Person: {person.FirstName} {person.LastName} \r\nAwards:{fullAwards.Trim()}";

            }

        }
        private void UpdateData()
        {
            gridPeople.DataSource = people.People.ToTable();
            gridAwards.DataSource = awards.Awards.ToTable();
            if (gridPeople.RowCount > 0)
            {
                gridPeople_CellClick(new object(), new DataGridViewCellEventArgs(gridPeople.SelectedCells[0].ColumnIndex, gridPeople.SelectedCells[0].RowIndex));
            }
            else
            {
                tbAwardsInfo.Clear();
            }

        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tcFullInfo.SelectedIndex == 0)
            {

                int ID = int.Parse(gridPeople[0, gridPeople.SelectedCells[0].RowIndex].Value.ToString());
                Person person = people.GetPerson(ID);
                AddForm form = new AddForm(person, awards.Awards);
                form.ShowDialog();


                if (form.DeleteState)
                {
                    people.DeletePerson(form.User);
                }
                else
                {
                    people.ReplaceData(form.User);
                    
                }

            }
            else if (tcFullInfo.SelectedIndex == 1)
            {
                int ID = int.Parse(gridAwards[0, gridAwards.SelectedCells[0].RowIndex].Value.ToString());
                Award award = awards.GetAward(ID);
                AddForm form = new AddForm(award);
                form.ShowDialog();

                if (form.DeleteState)
                {
                    foreach (Person i in people.People)
                    {
                        i.GetAwards().RemoveAll(item => item.ID == award.ID);
                    }
                    awards.DeleteAward(form.Award);
                }
                else
                {
                    awards.ReplaceData(form.Award);
                }

            }

            UpdateData();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientSizeChanged -= SizeComponents;
            Environment.Exit(0);
        }
    }
}
