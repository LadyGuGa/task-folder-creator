using System;
using System.IO;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using File = System.IO.File;

namespace CreateTaskFolder {
	public static class Business {
		public const string WrikeUrlPart = "https://www.wrike.com/open.htm?id=";
		public const string LocalPathPart = @"D:\Tasks\";

		public static void CreateTaskFolder(FolderParams folderParams) {
			string taskLink = WrikeUrlPart + folderParams.TaskId;
			string folderPath = (folderParams.ParentFolder == String.Empty)
				                    ? LocalPathPart + folderParams.TaskId
				                    : LocalPathPart + folderParams.ParentFolder + @"\" + folderParams.TaskId;
			
			Directory.CreateDirectory(folderPath);
			
			if (folderParams.CreateLnkFile)
				CreateShortcut(folderPath + @"\task.lnk", taskLink);
			if (folderParams.CreateTxtFile)
				File.WriteAllText(folderPath + @"\link.txt", taskLink);
			
			Clipboard.SetText(folderPath);
		}

		private static void CreateShortcut(string shortcutPath, string taskLink) {
			var shell = new WshShell();
			var shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
			shortcut.TargetPath = taskLink;
			shortcut.Save();
		}
	}
}
