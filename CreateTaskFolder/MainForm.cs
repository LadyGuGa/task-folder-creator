using System;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;

namespace CreateTaskFolder {
	public partial class CreateTaskFolderForm : Form {
		public CreateTaskFolderForm() {
			InitializeComponent();
			statusLabel.Text = GenerateStatusMessage();
			statusLabel.ForeColor = Color.DarkOrange;
			taskIdTextBox.Select();
		}

		private void createButton_Click(object sender, EventArgs e) {
			if (!TaskIdIsValid()) {
				statusLabel.Text = GenerateStatusMessage(Status.Error);
				statusLabel.ForeColor = Color.Red;
			} else {
				Business.CreateTaskFolder(new FolderParams(parentFolderComboBox.Text, taskIdTextBox.Text, createLnkCheckBox.Checked, createTxtCheckBox.Checked));
				statusLabel.Text = GenerateStatusMessage(Status.Success);
				statusLabel.ForeColor = Color.DarkGreen;
				taskIdTextBox.Select();
				taskIdTextBox.SelectAll();
			}
		}

		private bool TaskIdIsValid() {
			if (taskIdTextBox.Text == String.Empty)
				return false;
			return true;
		}

		private string GenerateStatusMessage(Status status = Status.None) {
			string statusMessage = String.Empty;
			switch (status) {
				case Status.None:
					if (parentFolderComboBox.Text == String.Empty)
						statusMessage = "Choose Parent folder";
					if (taskIdTextBox.Text == String.Empty) {
						statusMessage = (statusMessage == String.Empty)
							                ? "Enter Task ID"
							                : statusMessage + ", enter Task ID";
					}
					statusMessage = (statusMessage == String.Empty)
						                ? "Push the button"
						                : statusMessage + " and push the button";
					break;

				case Status.Success:
					statusMessage = $"Folder for task #{taskIdTextBox.Text} created. Full path copied to clipboard";
					break;

				case Status.Error:
					statusMessage = $"{taskIdLabel.Text} is empty";
					break;
			}
			return statusMessage;
		}

		private void parentFolderComboBox_TextChanged(object sender, EventArgs e) {
			statusLabel.Text = GenerateStatusMessage();
			statusLabel.ForeColor = Color.DarkOrange;
		}

		private void taskIdTextBox_TextChanged(object sender, EventArgs e) {
			statusLabel.Text = GenerateStatusMessage();
			statusLabel.ForeColor = Color.DarkOrange;
		}

		private void clearButton_Click(object sender, EventArgs e) {
			taskIdTextBox.Text = String.Empty;
		}
	}
}
