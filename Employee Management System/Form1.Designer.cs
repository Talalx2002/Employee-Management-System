namespace Employee_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dashBoardPanel = new System.Windows.Forms.Panel();
            this.searchButtom = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleLable = new System.Windows.Forms.Label();
            this.switchPanel = new System.Windows.Forms.Panel();
            this.dashBoardPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashBoardPanel
            // 
            this.dashBoardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            this.dashBoardPanel.Controls.Add(this.searchButtom);
            this.dashBoardPanel.Controls.Add(this.deletebutton);
            this.dashBoardPanel.Controls.Add(this.updateButton);
            this.dashBoardPanel.Controls.Add(this.viewButton);
            this.dashBoardPanel.Controls.Add(this.addButton);
            this.dashBoardPanel.Controls.Add(this.logoPanel);
            this.dashBoardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashBoardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashBoardPanel.Name = "dashBoardPanel";
            this.dashBoardPanel.Size = new System.Drawing.Size(236, 665);
            this.dashBoardPanel.TabIndex = 0;
            // 
            // searchButtom
            // 
            this.searchButtom.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchButtom.FlatAppearance.BorderSize = 0;
            this.searchButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButtom.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButtom.ForeColor = System.Drawing.Color.Gainsboro;
            this.searchButtom.Image = ((System.Drawing.Image)(resources.GetObject("searchButtom.Image")));
            this.searchButtom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButtom.Location = new System.Drawing.Point(0, 368);
            this.searchButtom.Name = "searchButtom";
            this.searchButtom.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.searchButtom.Size = new System.Drawing.Size(236, 72);
            this.searchButtom.TabIndex = 5;
            this.searchButtom.Text = "   Search";
            this.searchButtom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchButtom.UseVisualStyleBackColor = true;
            this.searchButtom.Click += new System.EventHandler(this.searchButtom_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deletebutton.FlatAppearance.BorderSize = 0;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebutton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deletebutton.ForeColor = System.Drawing.Color.Gainsboro;
            this.deletebutton.Image = ((System.Drawing.Image)(resources.GetObject("deletebutton.Image")));
            this.deletebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletebutton.Location = new System.Drawing.Point(0, 296);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.deletebutton.Size = new System.Drawing.Size(236, 72);
            this.deletebutton.TabIndex = 4;
            this.deletebutton.Text = "   Delete ";
            this.deletebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.updateButton.Image = ((System.Drawing.Image)(resources.GetObject("updateButton.Image")));
            this.updateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateButton.Location = new System.Drawing.Point(0, 224);
            this.updateButton.Name = "updateButton";
            this.updateButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.updateButton.Size = new System.Drawing.Size(236, 72);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "   Update ";
            this.updateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewButton.FlatAppearance.BorderSize = 0;
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.viewButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.viewButton.Image = ((System.Drawing.Image)(resources.GetObject("viewButton.Image")));
            this.viewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewButton.Location = new System.Drawing.Point(0, 152);
            this.viewButton.Name = "viewButton";
            this.viewButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.viewButton.Size = new System.Drawing.Size(236, 72);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "   View ";
            this.viewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.addButton.Image = ((System.Drawing.Image)(resources.GetObject("addButton.Image")));
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(0, 80);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.addButton.Size = new System.Drawing.Size(236, 72);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "   Add ";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(75)))));
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.ForeColor = System.Drawing.Color.Gainsboro;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logoPanel.Size = new System.Drawing.Size(236, 80);
            this.logoPanel.TabIndex = 1;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(150)))));
            this.TitlePanel.Controls.Add(this.cancelButton);
            this.TitlePanel.Controls.Add(this.titleLable);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(236, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(876, 80);
            this.TitlePanel.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.Location = new System.Drawing.Point(0, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.cancelButton.Size = new System.Drawing.Size(69, 72);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // titleLable
            // 
            this.titleLable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLable.ForeColor = System.Drawing.Color.White;
            this.titleLable.Location = new System.Drawing.Point(356, 28);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(76, 26);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "Home";
            // 
            // switchPanel
            // 
            this.switchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.switchPanel.AutoSize = true;
            this.switchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(205)))), ((int)(((byte)(224)))));
            this.switchPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.switchPanel.Location = new System.Drawing.Point(236, 80);
            this.switchPanel.Name = "switchPanel";
            this.switchPanel.Size = new System.Drawing.Size(876, 585);
            this.switchPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 665);
            this.Controls.Add(this.switchPanel);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.dashBoardPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dashBoardPanel.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel dashBoardPanel;
        private Button searchButtom;
        private Button deletebutton;
        private Button updateButton;
        private Button viewButton;
        public Button addButton;
        private Panel logoPanel;
        private Panel TitlePanel;
        private Label titleLable;
        private Panel switchPanel;
        private Button cancelButton;
    }
}