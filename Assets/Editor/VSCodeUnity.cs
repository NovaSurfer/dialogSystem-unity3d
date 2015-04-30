using UnityEngine;
using UnityEditor;
using System.IO;
using System.Text;

public class VSCodeUnity
{
	private const string VS11VersionString = "Microsoft Visual Studio Solution File, Format Version 11.00\r\n" +
		"# Visual Studio 2008\r\n";
	
	private const string VS12VersionString = "\r\nMicrosoft Visual Studio Solution File, Format Version 12.00\r\n" +
		"# Visual Studio 2012";
	
	[MenuItem("VS Code/Update project for Visual Studio Code")]
	private static void UpdateProjectForVCS()
	{
		string message = "";
		string path = Application.dataPath + "/..";
		
		DirectoryInfo directoryInfo = new DirectoryInfo( path);
		FileInfo[] files = directoryInfo.GetFiles();
		bool noSolutionFilesFound = true;
		
		foreach( FileInfo fileInfo in files)
		{
			if( fileInfo.Extension == ".sln")
			{
				noSolutionFilesFound = false;
				
				StreamReader reader = new StreamReader( fileInfo.ToString());
				string fileString = reader.ReadToEnd();
				reader.Close();
				
				if( fileString.Contains( VS11VersionString))
				{
					message += "\n Converting sln: " + fileInfo.Name;
					fileString = fileString.Replace( VS11VersionString, VS12VersionString);
					
					Stream stream = File.OpenWrite( fileInfo.ToString());
					StreamWriter writer = new StreamWriter( stream, new UTF8Encoding( true));
					writer.Write( fileString);
					writer.Close();
					
					if( fileInfo.Name.Contains( "-csharp"))
					{
						string oldPath = fileInfo.ToString();
						string newPath = oldPath.Replace( ".sln", ".sln.hide");
						File.Move( oldPath, newPath);
					}
				}
				else if( fileString.Contains( VS12VersionString))
				{
					message += "\n Skipping converted sln: " + fileInfo.Name;
				}
				else
				{
					message += "\n Skipping unknown sln format: " + fileInfo.Name;
				}
			}
		}
		
		if( noSolutionFilesFound)
		{
			message = "No .sln files found in project. Open a script in MonoDevelop to autogenerate .sln " +
				"files and then try updating for Visual Studio Code again.";
		}
		
		EditorUtility.DisplayDialog( "Update project", message, "Ok");
	}
}