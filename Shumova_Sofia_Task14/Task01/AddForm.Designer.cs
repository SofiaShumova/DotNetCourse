namespace Task01
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.cbObject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCreatePerson = new System.Windows.Forms.Panel();
            this.cbAwardForPerson = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btDeletePerson = new System.Windows.Forms.Button();
            this.btSaveInfoPerson = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPersons = new System.Windows.Forms.ComboBox();
            this.tbDateBirth = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.panelCreateAward = new System.Windows.Forms.Panel();
            this.btDeleteAward = new System.Windows.Forms.Button();
            this.btSaveInfoAward = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbAwards = new System.Windows.Forms.ComboBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panelCreatePerson.SuspendLayout();
            this.panelCreateAward.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMode
            // 
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "Edit",
            "Create"});
            this.cbMode.Location = new System.Drawing.Point(233, 85);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(258, 32);
            this.cbMode.TabIndex = 1;
            this.cbMode.SelectedIndexChanged += new System.EventHandler(this.cbMode_SelectedIndexChanged);
            // 
            // cbObject
            // 
            this.cbObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObject.FormattingEnabled = true;
            this.cbObject.Items.AddRange(new object[] {
            "Award",
            "Person"});
            this.cbObject.Location = new System.Drawing.Point(233, 138);
            this.cbObject.Name = "cbObject";
            this.cbObject.Size = new System.Drawing.Size(258, 32);
            this.cbObject.TabIndex = 2;
            this.cbObject.SelectedIndexChanged += new System.EventHandler(this.cbMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select object:";
            // 
            // panelCreatePerson
            // 
            this.panelCreatePerson.Controls.Add(this.cbAwardForPerson);
            this.panelCreatePerson.Controls.Add(this.label11);
            this.panelCreatePerson.Controls.Add(this.btDeletePerson);
            this.panelCreatePerson.Controls.Add(this.btSaveInfoPerson);
            this.panelCreatePerson.Controls.Add(this.label7);
            this.panelCreatePerson.Controls.Add(this.label6);
            this.panelCreatePerson.Controls.Add(this.label5);
            this.panelCreatePerson.Controls.Add(this.label3);
            this.panelCreatePerson.Controls.Add(this.cbPersons);
            this.panelCreatePerson.Controls.Add(this.tbDateBirth);
            this.panelCreatePerson.Controls.Add(this.tbLastName);
            this.panelCreatePerson.Controls.Add(this.tbFirstName);
            this.panelCreatePerson.Location = new System.Drawing.Point(12, 197);
            this.panelCreatePerson.Name = "panelCreatePerson";
            this.panelCreatePerson.Size = new System.Drawing.Size(593, 433);
            this.panelCreatePerson.TabIndex = 5;
            this.panelCreatePerson.Visible = false;
            // 
            // cbAwardForPerson
            // 
            this.cbAwardForPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAwardForPerson.FormattingEnabled = true;
            this.cbAwardForPerson.Items.AddRange(new object[] {
            "Награды",
            "Люди"});
            this.cbAwardForPerson.Location = new System.Drawing.Point(113, 246);
            this.cbAwardForPerson.Name = "cbAwardForPerson";
            this.cbAwardForPerson.Size = new System.Drawing.Size(258, 32);
            this.cbAwardForPerson.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-5, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Add award:";
            // 
            // btDeletePerson
            // 
            this.btDeletePerson.Location = new System.Drawing.Point(8, 368);
            this.btDeletePerson.Name = "btDeletePerson";
            this.btDeletePerson.Size = new System.Drawing.Size(570, 45);
            this.btDeletePerson.TabIndex = 13;
            this.btDeletePerson.Text = "Delete person";
            this.btDeletePerson.UseVisualStyleBackColor = true;
            this.btDeletePerson.Click += new System.EventHandler(this.btDeletePerson_Click);
            // 
            // btSaveInfoPerson
            // 
            this.btSaveInfoPerson.Location = new System.Drawing.Point(8, 317);
            this.btSaveInfoPerson.Name = "btSaveInfoPerson";
            this.btSaveInfoPerson.Size = new System.Drawing.Size(570, 45);
            this.btSaveInfoPerson.TabIndex = 12;
            this.btSaveInfoPerson.Text = "button1";
            this.btSaveInfoPerson.UseVisualStyleBackColor = true;
            this.btSaveInfoPerson.Click += new System.EventHandler(this.btSaveInfoPerson_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Birthday:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Surname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Person:";
            // 
            // cbPersons
            // 
            this.cbPersons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersons.FormattingEnabled = true;
            this.cbPersons.Items.AddRange(new object[] {
            "Награды",
            "Люди"});
            this.cbPersons.Location = new System.Drawing.Point(105, 19);
            this.cbPersons.Name = "cbPersons";
            this.cbPersons.Size = new System.Drawing.Size(258, 32);
            this.cbPersons.TabIndex = 6;
            this.cbPersons.SelectedIndexChanged += new System.EventHandler(this.cbPersons_SelectedIndexChanged);
            // 
            // tbDateBirth
            // 
            this.tbDateBirth.Location = new System.Drawing.Point(105, 194);
            this.tbDateBirth.Name = "tbDateBirth";
            this.tbDateBirth.Size = new System.Drawing.Size(217, 29);
            this.tbDateBirth.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(105, 132);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(217, 29);
            this.tbLastName.TabIndex = 1;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(105, 83);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(217, 29);
            this.tbFirstName.TabIndex = 0;
            // 
            // panelCreateAward
            // 
            this.panelCreateAward.Controls.Add(this.btDeleteAward);
            this.panelCreateAward.Controls.Add(this.btSaveInfoAward);
            this.panelCreateAward.Controls.Add(this.label8);
            this.panelCreateAward.Controls.Add(this.label9);
            this.panelCreateAward.Controls.Add(this.label10);
            this.panelCreateAward.Controls.Add(this.cbAwards);
            this.panelCreateAward.Controls.Add(this.tbDescription);
            this.panelCreateAward.Controls.Add(this.tbName);
            this.panelCreateAward.Location = new System.Drawing.Point(660, 197);
            this.panelCreateAward.Name = "panelCreateAward";
            this.panelCreateAward.Size = new System.Drawing.Size(593, 433);
            this.panelCreateAward.TabIndex = 6;
            this.panelCreateAward.Visible = false;
            // 
            // btDeleteAward
            // 
            this.btDeleteAward.Location = new System.Drawing.Point(8, 273);
            this.btDeleteAward.Name = "btDeleteAward";
            this.btDeleteAward.Size = new System.Drawing.Size(570, 45);
            this.btDeleteAward.TabIndex = 13;
            this.btDeleteAward.Text = "Delete award";
            this.btDeleteAward.UseVisualStyleBackColor = true;
            this.btDeleteAward.Click += new System.EventHandler(this.btDeleteAward_Click);
            // 
            // btSaveInfoAward
            // 
            this.btSaveInfoAward.Location = new System.Drawing.Point(8, 209);
            this.btSaveInfoAward.Name = "btSaveInfoAward";
            this.btSaveInfoAward.Size = new System.Drawing.Size(570, 45);
            this.btSaveInfoAward.TabIndex = 12;
            this.btSaveInfoAward.Text = "button1";
            this.btSaveInfoAward.UseVisualStyleBackColor = true;
            this.btSaveInfoAward.Click += new System.EventHandler(this.btSaveInfoAward_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Description:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "Award:";
            // 
            // cbAwards
            // 
            this.cbAwards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAwards.FormattingEnabled = true;
            this.cbAwards.Items.AddRange(new object[] {
            "Награды",
            "Люди"});
            this.cbAwards.Location = new System.Drawing.Point(105, 19);
            this.cbAwards.Name = "cbAwards";
            this.cbAwards.Size = new System.Drawing.Size(394, 32);
            this.cbAwards.TabIndex = 6;
            this.cbAwards.SelectedIndexChanged += new System.EventHandler(this.cbAwards_SelectedIndexChanged);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(124, 135);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(375, 29);
            this.tbDescription.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(124, 83);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(375, 29);
            this.tbName.TabIndex = 0;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 721);
            this.Controls.Add(this.panelCreateAward);
            this.Controls.Add(this.panelCreatePerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbObject);
            this.Controls.Add(this.cbMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editing data";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.panelCreatePerson.ResumeLayout(false);
            this.panelCreatePerson.PerformLayout();
            this.panelCreateAward.ResumeLayout(false);
            this.panelCreateAward.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.ComboBox cbObject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCreatePerson;
        private System.Windows.Forms.ComboBox cbPersons;
        private System.Windows.Forms.TextBox tbDateBirth;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSaveInfoPerson;
        private System.Windows.Forms.Panel panelCreateAward;
        private System.Windows.Forms.Button btSaveInfoAward;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbAwards;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btDeletePerson;
        private System.Windows.Forms.ComboBox cbAwardForPerson;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btDeleteAward;
    }
}