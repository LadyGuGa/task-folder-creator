namespace CreateTaskFolder {
	partial class CreateTaskFolderForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTaskFolderForm));
            this.parentFolderComboBox = new System.Windows.Forms.ComboBox();
            this.parentFolderLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.createLnkCheckBox = new System.Windows.Forms.CheckBox();
            this.createTxtCheckBox = new System.Windows.Forms.CheckBox();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.copyRightLinkLabel = new System.Windows.Forms.LinkLabel();
            this.taskIdLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.taskIdTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.optionsPanel.SuspendLayout();
            this.optionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // parentFolderComboBox
            // 
            this.parentFolderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parentFolderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentFolderComboBox.FormattingEnabled = true;
            this.parentFolderComboBox.Items.AddRange(new object[] {
            "",
            "Hotfixes",
            "Notify Clients",
            "Support Requests",
            "Issues",
            "New Forms",
            "Acord XML",
            "Appulate PDF",
            "Other"});
            this.parentFolderComboBox.Location = new System.Drawing.Point(7, 24);
            this.parentFolderComboBox.Name = "parentFolderComboBox";
            this.parentFolderComboBox.Size = new System.Drawing.Size(434, 28);
            this.parentFolderComboBox.TabIndex = 2;
            this.parentFolderComboBox.Text = "Support Requests";
            this.parentFolderComboBox.TextChanged += new System.EventHandler(this.parentFolderComboBox_TextChanged);
            // 
            // parentFolderLabel
            // 
            this.parentFolderLabel.AutoSize = true;
            this.parentFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parentFolderLabel.Location = new System.Drawing.Point(7, 3);
            this.parentFolderLabel.Name = "parentFolderLabel";
            this.parentFolderLabel.Size = new System.Drawing.Size(105, 20);
            this.parentFolderLabel.TabIndex = 0;
            this.parentFolderLabel.Text = "Parent folder";
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.statusLabel.Location = new System.Drawing.Point(7, 179);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(129, 18);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Status message";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createLnkCheckBox
            // 
            this.createLnkCheckBox.AutoSize = true;
            this.createLnkCheckBox.Checked = true;
            this.createLnkCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.createLnkCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createLnkCheckBox.Location = new System.Drawing.Point(6, 25);
            this.createLnkCheckBox.Name = "createLnkCheckBox";
            this.createLnkCheckBox.Size = new System.Drawing.Size(83, 24);
            this.createLnkCheckBox.TabIndex = 4;
            this.createLnkCheckBox.Text = ".lnk file";
            this.createLnkCheckBox.UseVisualStyleBackColor = true;
            // 
            // createTxtCheckBox
            // 
            this.createTxtCheckBox.AutoSize = true;
            this.createTxtCheckBox.Checked = true;
            this.createTxtCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.createTxtCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTxtCheckBox.Location = new System.Drawing.Point(6, 55);
            this.createTxtCheckBox.Name = "createTxtCheckBox";
            this.createTxtCheckBox.Size = new System.Drawing.Size(80, 24);
            this.createTxtCheckBox.TabIndex = 5;
            this.createTxtCheckBox.Text = ".txt file";
            this.createTxtCheckBox.UseVisualStyleBackColor = true;
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.statusLabel);
            this.optionsPanel.Controls.Add(this.copyRightLinkLabel);
            this.optionsPanel.Controls.Add(this.taskIdLabel);
            this.optionsPanel.Controls.Add(this.clearButton);
            this.optionsPanel.Controls.Add(this.parentFolderLabel);
            this.optionsPanel.Controls.Add(this.taskIdTextBox);
            this.optionsPanel.Controls.Add(this.parentFolderComboBox);
            this.optionsPanel.Controls.Add(this.createButton);
            this.optionsPanel.Controls.Add(this.optionsGroupBox);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsPanel.Location = new System.Drawing.Point(0, 0);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(582, 203);
            this.optionsPanel.TabIndex = 0;
            // 
            // copyRightLinkLabel
            // 
            this.copyRightLinkLabel.ActiveLinkColor = System.Drawing.Color.Black;
            this.copyRightLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyRightLinkLabel.AutoSize = true;
            this.copyRightLinkLabel.DisabledLinkColor = System.Drawing.Color.Black;
            this.copyRightLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.copyRightLinkLabel.LinkColor = System.Drawing.Color.Gray;
            this.copyRightLinkLabel.Location = new System.Drawing.Point(470, 181);
            this.copyRightLinkLabel.Name = "copyRightLinkLabel";
            this.copyRightLinkLabel.Size = new System.Drawing.Size(106, 15);
            this.copyRightLinkLabel.TabIndex = 7;
            this.copyRightLinkLabel.TabStop = true;
            this.copyRightLinkLabel.Text = "by L.Moskvenkova";
            this.copyRightLinkLabel.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // taskIdLabel
            // 
            this.taskIdLabel.AutoSize = true;
            this.taskIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskIdLabel.Location = new System.Drawing.Point(7, 56);
            this.taskIdLabel.Name = "taskIdLabel";
            this.taskIdLabel.Size = new System.Drawing.Size(67, 20);
            this.taskIdLabel.TabIndex = 0;
            this.taskIdLabel.Text = "Task ID";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(417, 79);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(24, 24);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "X";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // taskIdTextBox
            // 
            this.taskIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskIdTextBox.Location = new System.Drawing.Point(7, 77);
            this.taskIdTextBox.Name = "taskIdTextBox";
            this.taskIdTextBox.Size = new System.Drawing.Size(404, 26);
            this.taskIdTextBox.TabIndex = 1;
            this.taskIdTextBox.TextChanged += new System.EventHandler(this.taskIdTextBox_TextChanged);
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createButton.Location = new System.Drawing.Point(7, 110);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(568, 65);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsGroupBox.Controls.Add(this.createTxtCheckBox);
            this.optionsGroupBox.Controls.Add(this.createLnkCheckBox);
            this.optionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.optionsGroupBox.Location = new System.Drawing.Point(447, 3);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(128, 101);
            this.optionsGroupBox.TabIndex = 0;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Save link as";
            // 
            // CreateTaskFolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 203);
            this.Controls.Add(this.optionsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 250);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "CreateTaskFolderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Task Folder";
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox parentFolderComboBox;
		private System.Windows.Forms.Label parentFolderLabel;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.CheckBox createLnkCheckBox;
		private System.Windows.Forms.CheckBox createTxtCheckBox;
		private System.Windows.Forms.Panel optionsPanel;
		private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.Label taskIdLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox taskIdTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.LinkLabel copyRightLinkLabel;
    }
}

