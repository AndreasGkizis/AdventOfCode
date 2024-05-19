using System.Reflection;

namespace Helpers;

public static class Helpers
{
	public static string FindInputTxtFile()
	{
		string projectDirectory = FindProjectRootDirectory(Directory.GetCurrentDirectory());
		return FindFileInDirectory(projectDirectory, "input.txt");
	}

	private static string FindProjectRootDirectory(string directory)
	{
		// Check if the current directory contains a .csproj file
		if (Directory.GetFiles(directory, "*.csproj").Length > 0)
		{
			return directory;
		}

		// Move to the parent directory if no .csproj file is found
		DirectoryInfo parentDirectory = Directory.GetParent(directory);
		if (parentDirectory != null)
		{
			return FindProjectRootDirectory(parentDirectory.FullName);
		}

		// If we reach the root directory and still no .csproj file found, throw an exception
		throw new DirectoryNotFoundException("No project root directory found.");
	}

	private static string FindFileInDirectory(string directory, string fileName)
	{
		foreach (var file in Directory.GetFiles(directory, fileName))
		{
			return file;
		}

		foreach (var dir in Directory.GetDirectories(directory))
		{
			string result = FindFileInDirectory(dir, fileName);
			if (result != null)
			{
				return result;
			}
		}
		return null;
	}
}
