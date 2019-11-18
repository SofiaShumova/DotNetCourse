namespace Task01
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcFullInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbAwardsInfo = new System.Windows.Forms.TextBox();
            this.gridPeople = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridAwards = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcFullInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeople)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAwards)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcFullInfo
            // 
            this.tcFullInfo.Controls.Add(this.tabPage1);
            this.tcFullInfo.Controls.Add(this.tabPage2);
            this.tcFullInfo.ItemSize = new System.Drawing.Size(200, 50);
            this.tcFullInfo.Location = new System.Drawing.Point(0, 48);
            this.tcFullInfo.Name = "tcFullInfo";
            this.tcFullInfo.SelectedIndex = 0;
            this.tcFullInfo.Size = new System.Drawing.Size(1086, 546);
            this.tcFullInfo.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcFullInfo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbAwardsInfo);
            this.tabPage1.Controls.Add(this.gridPeople);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1078, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "People";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbAwardsInfo
            // 
            this.tbAwardsInfo.Location = new System.Drawing.Point(788, 20);
            this.tbAwardsInfo.Multiline = true;
            this.tbAwardsInfo.Name = "tbAwardsInfo";
            this.tbAwardsInfo.ReadOnly = true;
            this.tbAwardsInfo.Size = new System.Drawing.Size(274, 432);
            this.tbAwardsInfo.TabIndex = 1;
            // 
            // gridPeople
            // 
            this.gridPeople.AllowUserToAddRows = false;
            this.gridPeople.AllowUserToDeleteRows = false;
            this.gridPeople.AllowUserToResizeColumns = false;
            this.gridPeople.AllowUserToResizeRows = false;
            this.gridPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPeople.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridPeople.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPeople.Location = new System.Drawing.Point(21, 20);
            this.gridPeople.Name = "gridPeople";
            this.gridPeople.ReadOnly = true;
            this.gridPeople.RowHeadersVisible = false;
            this.gridPeople.RowHeadersWidth = 72;
            this.gridPeople.RowTemplate.Height = 31;
            this.gridPeople.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridPeople.Size = new System.Drawing.Size(739, 432);
            this.gridPeople.TabIndex = 0;
            this.gridPeople.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPeople_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridAwards);
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1078, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Awards";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridAwards
            // 
            this.gridAwards.AllowUserToAddRows = false;
            this.gridAwards.AllowUserToDeleteRows = false;
            this.gridAwards.AllowUserToResizeColumns = false;
            this.gridAwards.AllowUserToResizeRows = false;
            this.gridAwards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAwards.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridAwards.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridAwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAwards.Location = new System.Drawing.Point(15, 16);
            this.gridAwards.Name = "gridAwards";
            this.gridAwards.ReadOnly = true;
            this.gridAwards.RowHeadersVisible = false;
            this.gridAwards.RowHeadersWidth = 72;
            this.gridAwards.RowTemplate.Height = 31;
            this.gridAwards.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridAwards.Size = new System.Drawing.Size(765, 432);
            this.gridAwards.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1401, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(85, 34);
            this.менюToolStripMenuItem.Text = "Menu";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(224, 40);
            this.добавитьToolStripMenuItem.Text = "Add / edit";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 40);
            this.выходToolStripMenuItem.Text = "Exit";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 967);
            this.Controls.Add(this.tcFullInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "People and awards";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcFullInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPeople)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAwards)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcFullInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gridPeople;
        private System.Windows.Forms.DataGridView gridAwards;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TextBox tbAwardsInfo;
    }
}

