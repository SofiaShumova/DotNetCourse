using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task01
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AppendInfoAwards(ComboBox cb)
        {
            cb.Items.Clear();

            foreach (Award i in MainForm.awards)
            {
                cb.Items.Add(i.Name);
            }
        }
        private void AppendInfoAwards(ComboBox cb, Person person)
        {
            cb.Items.Clear();

            foreach (Award i in MainForm.awards)
            {
                cb.Items.Add(i.Name);
            }

            foreach (Award i in person.GetAwards())
            {
                cb.Items.Remove(i.Name);
            }
        }
        private void cbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            if (cbObject.SelectedIndex == 1 && cbMode.SelectedItem != null)
            {

                panelCreatePerson.Visible = true;
                panelCreateAward.Visible = false;
                btDeletePerson.Enabled = false;
                if (cbMode.SelectedIndex == 1)
                {
                    AppendInfoAwards(cbAwardForPerson);
                    cbPersons.Enabled = false;
                    label3.Enabled = false;
                    btSaveInfoPerson.Text = "Create";
                    cbAwardForPerson.Enabled = true;
                }
                if (cbMode.SelectedIndex == 0)
                {
                    cbAwardForPerson.Items.Clear();
                    cbPersons.Enabled = true;
                    ComboBoxPerson();
                    label3.Enabled = true;
                    btSaveInfoPerson.Text = "Save changes";
                    cbAwardForPerson.Enabled = false;
                }
            }

            if (cbObject.SelectedIndex == 0 && cbMode.SelectedItem != null)
            {
                panelCreatePerson.Visible = false;
                panelCreateAward.Visible = true;
                panelCreateAward.Location = new Point(panelCreatePerson.Location.X, panelCreatePerson.Location.Y);

                if (cbMode.SelectedIndex == 1) //create
                {
                    cbAwards.Enabled = false;
                    label10.Enabled = false;
                    btSaveInfoAward.Text = "Create";
                    btDeleteAward.Enabled = false;

                }
                if (cbMode.SelectedIndex == 0) //edit
                {
                    cbAwards.Enabled = true;
                    label10.Enabled = true;
                    btSaveInfoAward.Text = "Save changes";
                    btDeleteAward.Enabled = false;

                    ComboBoxAward();

                }
            }
        }
        private void ComboBoxAward()
        {
            cbAwards.Items.Clear();

            foreach (Award i in MainForm.awards)
            {
                cbAwards.Items.Add(i.Name);
            }
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private void ComboBoxPerson()
        {
            cbPersons.Items.Clear();

            foreach (Person i in MainForm.people)
            {
                cbPersons.Items.Add(i.FirstName + " " + i.LastName);
            }
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(350, 400);
        }

        private void cbPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPersons.SelectedItem != null)
            {
                cbAwardForPerson.Enabled = true;
                btDeletePerson.Enabled = true;
            }
            tbFirstName.Text = MainForm.people[cbPersons.SelectedIndex].FirstName;
            tbLastName.Text = MainForm.people[cbPersons.SelectedIndex].LastName;
            tbDateBirth.Text = MainForm.people[cbPersons.SelectedIndex].DateBirth.ToShortDateString();
            AppendInfoAwards(cbAwardForPerson, MainForm.people[cbPersons.SelectedIndex]);
        }
        public Person User;
        private void btSaveInfoPerson_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text != null && tbLastName.Text != null && DateTime.TryParse(tbDateBirth.Text, out DateTime date))
            {
                if (cbMode.SelectedIndex == 1) // create
                {
                    MainForm.people.Add(new Person(tbFirstName.Text, tbLastName.Text, date));
                    if (cbAwardForPerson.SelectedItem != null)
                    {
                        MainForm.people[MainForm.people.Count - 1].AddNewAward(MainForm.awards[cbAwardForPerson.SelectedIndex]);
                    }
                }
                if (cbMode.SelectedIndex == 0) //edit
                {
                    MainForm.people[cbPersons.SelectedIndex].FirstName = tbFirstName.Text;
                    MainForm.people[cbPersons.SelectedIndex].LastName = tbLastName.Text;
                    MainForm.people[cbPersons.SelectedIndex].DateBirth = date;

                    if (cbAwardForPerson.SelectedItem != null)
                    {
                        MainForm.people[cbPersons.SelectedIndex].AddNewAward(
                            MainForm.awards.SingleOrDefault(item => item.Name == cbAwardForPerson.SelectedItem.ToString()));
                        //Info();

                    }
                }
                MessageBox.Show("Success!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect data!");
            }
        }
        private void btDeletePerson_Click(object sender, EventArgs e)
        {
            if (cbPersons.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    MainForm.people.RemoveAt(cbPersons.SelectedIndex);
                    MessageBox.Show("Success!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Select person!");
            }

        }

        private void cbAwards_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbName.Text = MainForm.awards[cbAwards.SelectedIndex].Name;
            tbDescription.Text = MainForm.awards[cbAwards.SelectedIndex].Description;
            if (cbAwards.SelectedItem != null)
            {
                btDeleteAward.Enabled = true;
            }
        }

        private void btSaveInfoAward_Click(object sender, EventArgs e)
        {
            if (tbName.Text != null)
            {
                if (cbMode.SelectedIndex == 1) // create
                {
                    MainForm.awards.Add(new Award(tbName.Text, tbDescription.Text));
                }
                if (cbMode.SelectedIndex == 0)//edit
                {
                    MainForm.awards[cbAwards.SelectedIndex].Name = tbName.Text;
                    MainForm.awards[cbAwards.SelectedIndex].Description = tbDescription.Text;
                }
                MessageBox.Show("Success!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect data!");
            }
        }

        private void btDeleteAward_Click(object sender, EventArgs e)
        {
            if (cbAwards.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    foreach (Person i in MainForm.people)
                    {
                        i.DeleteAward(MainForm.awards.Single(item => item.ID == MainForm.awards[cbAwards.SelectedIndex].ID));
                    }
                    MainForm.awards.Remove(MainForm.awards[cbAwards.SelectedIndex]);
                    MessageBox.Show("Success!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Select award!");
            }
        }
    }
}
