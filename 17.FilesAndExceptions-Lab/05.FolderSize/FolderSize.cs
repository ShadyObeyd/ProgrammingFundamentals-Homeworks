using System.IO;

namespace _05.FolderSize
{
    class FolderSize
    {
        static void Main()
        {
            string[] dir = Directory.GetFiles("TestFolder");

            double size = 0;

            foreach (string file in dir)
            {
                FileInfo info = new FileInfo(file);

                size += info.Length; 
            }

            size = size / 1024 / 1024;

            File.WriteAllText("Output.txt", size.ToString());
        }
    }
}
