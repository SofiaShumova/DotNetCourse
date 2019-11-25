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
            this.components = new System.ComponentModel.Container();
            this.panelCreatePerson = new System.Windows.Forms.Panel();
            this.cbAwardForPerson = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btDeletePerson = new System.Windows.Forms.Button();
            this.btSaveInfoPerson = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDateBirth = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.panelCreateAward = new System.Windows.Forms.Panel();
            this.btDeleteAward = new System.Windows.Forms.Button();
            this.btSaveInfoAward = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelCreatePerson.SuspendLayout();
            this.panelCreateAward.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
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
            this.panelCreatePerson.Controls.Add(this.tbDateBirth);
            this.panelCreatePerson.Controls.Add(this.tbLastName);
            this.panelCreatePerson.Controls.Add(this.tbFirstName);
            this.panelCreatePerson.Location = new System.Drawing.Point(12, 18);
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
            this.btDeletePerson.Visible = false;
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
            // tbDateBirth
            // 
            this.tbDateBirth.Location = new System.Drawing.Point(105, 194);
            this.tbDateBirth.Name = "tbDateBirth";
            this.tbDateBirth.Size = new System.Drawing.Size(217, 29);
            this.tbDateBirth.TabIndex = 2;
            this.tbDateBirth.Validating += new System.ComponentModel.CancelEventHandler(this.tbDateBirth_Validating);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(105, 132);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(217, 29);
            this.tbLastName.TabIndex = 1;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(105, 83);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(217, 29);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            // 
            // panelCreateAward
            // 
            this.panelCreateAward.Controls.Add(this.btDeleteAward);
            this.panelCreateAward.Controls.Add(this.btSaveInfoAward);
            this.panelCreateAward.Controls.Add(this.label8);
            this.panelCreateAward.Controls.Add(this.label9);
            this.panelCreateAward.Controls.Add(this.tbDescription);
            this.panelCreateAward.Controls.Add(this.tbName);
            this.panelCreateAward.Location = new System.Drawing.Point(652, 27);
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
            this.btDeleteAward.Visible = false;
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
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 506);
            this.Controls.Add(this.panelCreateAward);
            this.Controls.Add(this.panelCreatePerson);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCreatePerson;
        private System.Windows.Forms.TextBox tbDateBirth;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSaveInfoPerson;
        private System.Windows.Forms.Panel panelCreateAward;
        private System.Windows.Forms.Button btSaveInfoAward;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btDeletePerson;
        private System.Windows.Forms.ComboBox cbAwardForPerson;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btDeleteAward;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}