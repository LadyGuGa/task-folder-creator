namespace CreateTaskFolder {
	public class FolderParams {
		public FolderParams(string parentFolder, string taskId, bool createLnk, bool createTxt) {
			ParentFolder = parentFolder;
			TaskId = taskId;
			CreateLnkFile = createLnk;
			CreateTxtFile = createTxt;
		}

		public string ParentFolder { get; set; }
		public string TaskId { get; set; }

		public bool CreateLnkFile { get; set; }
		public bool CreateTxtFile { get; set; }
	}
}
