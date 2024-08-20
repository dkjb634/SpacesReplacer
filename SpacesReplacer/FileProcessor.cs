namespace SpacesReplacer;

public class FileProcessor
{
		public static int ReplaceInFile(string pathToFile, string whatToReplace, string replaceOn)
		{
			if (string.IsNullOrEmpty(pathToFile))
				throw new ArgumentException("Path to file cannot be null or empty", nameof(pathToFile));
			if (!File.Exists(pathToFile))
				throw new FileNotFoundException("The specified file does not exist", pathToFile);

			string[] lines = File.ReadAllLines(pathToFile);
			for (int i = 0; i < lines.Length; i++) { lines[i] = lines[i].Replace(whatToReplace, replaceOn); }

			File.WriteAllLines(pathToFile, lines);
			return 0;
		}
	
}