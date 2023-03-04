using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace NNImagePreparer
{
	public partial class Form1 : Form
	{

		string fileRes = "jpeg";
		public Form1()
		{
			InitializeComponent();
		}

		private void OpenInputFileDialogBtn_Click(object sender, EventArgs e)
		{
			using (var folderBrowserDialog = new FolderBrowserDialog())
			{
				folderBrowserDialog.Description = "Select root directory for the frames";
				DialogResult result = folderBrowserDialog.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
				{ 
					inPathBox.Text = folderBrowserDialog.SelectedPath;
					totalFilesLabel.Text = new DirTree(folderBrowserDialog.SelectedPath).CollectFiles(fileRes).Count().ToString();
				} 
			}
		}

		private void OpenOutputFileDialogBtn_Click(object sender, EventArgs e)
		{
			using (var folderBrowserDialog = new FolderBrowserDialog())
			{
				folderBrowserDialog.Description = "Select root directory for the frames";
				DialogResult result = folderBrowserDialog.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
					outPathBox.Text = folderBrowserDialog.SelectedPath;
			}
		}
	
		bool Validate()
		{
			if (!Directory.Exists(inPathBox.Text))
				return false;
			if (!Directory.Exists(outPathBox.Text))
				return false;
			return true;
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			if (!Validate())
			{
				MessageBox.Show("Invalid path!");
				return;
			}
			var dirTree = new DirTree(inPathBox.Text);
			dirTree.DropBranches(x => x.CollectFiles(fileRes).Any());
			dirTree.CopyDirectoryHierarchy(outPathBox.Text);
			var srcFiles = dirTree.CollectFiles(fileRes);
			
			progressBar.Maximum = srcFiles.Count();
			progressBar.Value = 0;

			foreach (var file in srcFiles)
			{
				var resultImage = ProcessImage(ImageHelper.ByteArrayToImage(File.ReadAllBytes(file.FullName)));
				var newPath = dirTree.ProjectPath(file.FullName, outPathBox.Text);
				File.WriteAllBytes(newPath, resultImage);
				progressBar.Invoke(() =>
				{
					progressBar.Value++;
				});
			}
		}

		byte[] ProcessImage(Image image)
		{
			byte[] result = ImageHelper.ImageToByteArray(image);
			if (cropCheckBox.Checked)
			{
				int size = Math.Min(image.Width, image.Height);
				int y = (image.Height - size) / 2;
				int x = (image.Width - size) / 2;
				result = ImageHelper.CropImage(result, x, y, size, size);
			}
			return ImageHelper.ImageToByteArray(ImageHelper.Resize(ImageHelper.ByteArrayToImage(result), 
				(int)resolutionXUpDown.Value, (int)resolutionYUpDown.Value));
		}

		class DirTree
		{
			public class DirTreeNode
			{
				public string path;
				List<DirTreeNode> children = new List<DirTreeNode>();
				public DirTreeNode(string path)
				{
					this.path = path;
					foreach(var dir in Directory.GetDirectories(path))
						children.Add(new DirTreeNode(dir));
				}

				public IEnumerable<string> GetNestedDirectories()
				{
					yield return path;
					foreach(var child in children.SelectMany(x=>x.GetNestedDirectories()))
						yield return child;
				}

				public void DropBranches(Func<string, bool> filter)
				{
					children = children.Where(x => filter(x.path)).ToList();
					foreach (var ch in children)
						ch.DropBranches(filter);
				}
				public void DropBranches(Func<DirTreeNode, bool> filter)
				{
					children = children.Where(x => filter(x)).ToList();
					foreach (var ch in children)
						ch.DropBranches(filter);
				}

				public IEnumerable<FileInfo> CollectFiles(params string[] extensions)
				{
					foreach(var ext in extensions)
						foreach (var file in Directory.GetFiles(path, "*." + ext))
							yield return new FileInfo(file);
					foreach(var child in children.SelectMany(x=>x.CollectFiles(extensions)))
						yield return child;
				}

				public void CopyDirectoryHierarchy(string targetPathRoot, string rootPath = "", bool root = true)
				{
					if (root)
						foreach (var child in children)
							child.CopyDirectoryHierarchy(targetPathRoot, path, root: false);
					else
					{
						var newPath = Path.Combine(targetPathRoot, Path.GetRelativePath(rootPath, path));
						if(!Directory.Exists(newPath))
							Directory.CreateDirectory(newPath);
						foreach (var child in children)
							child.CopyDirectoryHierarchy(newPath, path, root: false);
					}
				}
			}

			DirTreeNode root;

			public DirTree(string path) 
			{
				root = new DirTreeNode(path);
			}

			public IEnumerable<string> GetNestedDirectories()=> root?.GetNestedDirectories();

			public void DropBranches(Func<string, bool> filter)
			{
				if (root == null)
					return;
				root.DropBranches(filter);
			}

			public void DropBranches(Func<DirTreeNode, bool> filter)
			{
				if (root == null)
					return;
				root.DropBranches(filter);
			}

			public IEnumerable<FileInfo> CollectFiles(params string[] extensions)
			{
				if (root == null)
					return null;
				return root.CollectFiles(extensions);
			}
			

			/// <summary>
			/// Create directory structure identical to the described one in the targetPath folder
			/// </summary>
			public void CopyDirectoryHierarchy(string targetPath)
			{
				if(root == null) 
					return;
				root.CopyDirectoryHierarchy(targetPath);
			}

			public string ProjectPath(string sourceFullPath, string targetPathRoot)
			{
				return Path.Combine(targetPathRoot, Path.GetRelativePath(root.path, sourceFullPath));
			}
		}
	}
}