namespace Prog2Start
{
    partial class FurnitureForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            insertToolStripMenuItem = new ToolStripMenuItem();
            couchToolStripMenuItem = new ToolStripMenuItem();
            deskChairToolStripMenuItem = new ToolStripMenuItem();
            furnListView = new ListView();
            furnTypeCol = new ColumnHeader();
            weightCol = new ColumnHeader();
            categoryCol = new ColumnHeader();
            detailButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, insertToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(538, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { couchToolStripMenuItem, deskChairToolStripMenuItem });
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(59, 24);
            insertToolStripMenuItem.Text = "Insert";
            // 
            // couchToolStripMenuItem
            // 
            couchToolStripMenuItem.Name = "couchToolStripMenuItem";
            couchToolStripMenuItem.Size = new Size(224, 26);
            couchToolStripMenuItem.Text = "Couch";
            couchToolStripMenuItem.Click += couchToolStripMenuItem_Click;
            // 
            // deskChairToolStripMenuItem
            // 
            deskChairToolStripMenuItem.Name = "deskChairToolStripMenuItem";
            deskChairToolStripMenuItem.Size = new Size(224, 26);
            deskChairToolStripMenuItem.Text = "Desk Chair";
            deskChairToolStripMenuItem.Click += this.deskChairToolStripMenuItem_Click;
            // 
            // furnListView
            // 
            furnListView.Columns.AddRange(new ColumnHeader[] { furnTypeCol, weightCol, categoryCol });
            furnListView.FullRowSelect = true;
            furnListView.GridLines = true;
            furnListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            furnListView.Location = new Point(20, 44);
            furnListView.MultiSelect = false;
            furnListView.Name = "furnListView";
            furnListView.Size = new Size(498, 304);
            furnListView.TabIndex = 1;
            furnListView.UseCompatibleStateImageBehavior = false;
            furnListView.View = View.Details;
            // 
            // furnTypeCol
            // 
            furnTypeCol.Text = "Furniture Type";
            furnTypeCol.Width = 166;
            // 
            // weightCol
            // 
            weightCol.Text = "Weight";
            weightCol.Width = 160;
            // 
            // categoryCol
            // 
            categoryCol.Text = "Category";
            categoryCol.Width = 160;
            // 
            // detailButton
            // 
            detailButton.Location = new Point(222, 354);
            detailButton.Name = "detailButton";
            detailButton.Size = new Size(94, 29);
            detailButton.TabIndex = 2;
            detailButton.Text = "Details";
            detailButton.UseVisualStyleBackColor = true;
            detailButton.Click += detailButton_Click;
            // 
            // FurnitureForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 391);
            Controls.Add(detailButton);
            Controls.Add(furnListView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FurnitureForm";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Furniture Form";
            Load += FurnitureForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem couchToolStripMenuItem;
        private ToolStripMenuItem deskChairToolStripMenuItem;
        private ListView furnListView;
        private ColumnHeader furnTypeCol;
        private ColumnHeader weightCol;
        private ColumnHeader categoryCol;
        private Button detailButton;
    }
}
