using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace Task01
{
    public partial class AddForm : Form
    {
        public Person User;
        public Award Award;
        public bool DeleteState;
        List<Award> awards;

        public AddForm(bool person, List<Award> listAward) //false - award true - person
        {
            InitializeComponent();
            awards = listAward;
            if (person)
            {
                this.Text = "Create person";
                StartPersonCreate();

            }
            else
            {
                this.Text = "Create award";
                StartAwardCreate();

            }

        }

        public AddForm(Award award)
        {
            InitializeComponent();
            Award = award;
            StartAwardEdit(award);

            this.Text = "Edit award";
        }
        public AddForm(Person person, List<Award> listAward)
        {
            InitializeComponent();
            awards = listAward;
            User = person;
            StartPersonEdit(person);
            this.Text = "Edit person";

        }

        private void StartPersonCreate()
        {
            panelCreatePerson.Visible = true;

            AppendInfoAwards(cbAwardForPerson, awards);

            btSaveInfoPerson.Text = "Create";
            cbAwardForPerson.Enabled = true;
        }

        private void StartAwardCreate()
        {
            panelCreateAward.Visible = true;
            panelCreateAward.Location = new Point(panelCreatePerson.Location.X, panelCreatePerson.Location.Y);

            btSaveInfoAward.Text = "Create";
        }

        private void StartAwardEdit(Award award)
        {
            panelCreateAward.Visible = true;
            panelCreateAward.Location = new Point(panelCreatePerson.Location.X, panelCreatePerson.Location.Y);


            btSaveInfoAward.Text = "Save changes";

            tbName.Text = award.Name;
            tbDescription.Text = award.Description;

        }

        private void StartPersonEdit(Person person)
        {
            panelCreatePerson.Visible = true;

            btSaveInfoPerson.Text = "Save changes";
            btDeletePerson.Visible = true;
            AppendInfoAwards(cbAwardForPerson, person, awards);

            tbFirstName.Text = person.FirstName;
            tbLastName.Text = person.LastName;
            tbDateBirth.Text = person.DateBirth.ToShortDateString();

        }



        private void AppendInfoAwards(ComboBox cb, List<Award> list)
        {
            cb.Items.Clear();

            foreach (Award i in list)
            {
                cb.Items.Add(i.Name);
            }
        }
        private void AppendInfoAwards(ComboBox cb, Person p, List<Award> list) // oop
        {
            cb.Items.Clear();

            foreach (Award i in list)
            {
                cb.Items.Add(i.Name);
            }

            foreach (Award i in User.GetAwards())
            {
                cb.Items.Remove(i.Name);
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


        private void AddForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(350, 300);
            DeleteState = false;
           
        }



        private void btSaveInfoPerson_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (btSaveInfoPerson.Text == "Save changes")
                {
                    User.FirstName = tbFirstName.Text;
                    User.LastName = tbLastName.Text;
                    User.DateBirth = DateTime.Parse(tbDateBirth.Text);

                }
                else if (btSaveInfoPerson.Text == "Create")
                {
                    User = new Person(tbFirstName.Text, tbLastName.Text, DateTime.Parse(tbDateBirth.Text));
                }
                if (cbAwardForPerson.SelectedItem != null)
                {
                    User.AddNewAward(awards[awards.FindIndex(item => item.Name == cbAwardForPerson.Text)]);
                }

                MessageBox.Show("Success!");
                this.Close();

            }
            else
            {

                MessageBox.Show("Incorret data!");
            }
          
        }
        private void btDeletePerson_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                DeleteState = true;
                this.Close();
            }
        }



        private void btSaveInfoAward_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (btSaveInfoAward.Text == "Save changes") // create
                {
                    Award.Name = tbName.Text;
                    Award.Description = tbDescription.Text;
                }
                if (btSaveInfoAward.Text == "Create")
                {
                    Award = new Award(tbName.Text, tbDescription.Text);
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
            DialogResult result = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                DeleteState = true;
                this.Close();
            }

        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.Clear();
            if (tbFirstName.Text == string.Empty)
            {
                errorProvider.SetError(tbFirstName, "Incorret firstname!");
                e.Cancel = true;
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.Clear();
            if (tbLastName.Text == string.Empty)
            {
                errorProvider.SetError(tbLastName, "Incorret lastname!");
                e.Cancel = true;
            }
        }

        private void tbDateBirth_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.Clear();
            if (tbDateBirth.Text == string.Empty || !DateTime.TryParse(tbDateBirth.Text, out DateTime date))
            {
                errorProvider.SetError(tbDateBirth, "Incorret data!");
                e.Cancel = true;
            }

        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            errorProvider.Clear();
            if (tbLastName.Text == string.Empty)
            {
                errorProvider.SetError(tbName, "Incorret name!");
                e.Cancel = true;
            }
        }
    }
}
