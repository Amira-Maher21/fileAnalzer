using fileAnalzer;

namespace FIleAnalzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine(" Please enter folder Path to Anlyzer");

          string inputFolder = Console.ReadLine();
            DirectoryInfo directoryInfo = new DirectoryInfo(inputFolder);

            if (directoryInfo.Exists == false) {
                Console.WriteLine("Folder dosnt exist");
                return;
             }

           var filenams = directoryInfo.GetFiles();
            foreach (var file in filenams)
            {
                IFileAnalyzer fileAnalzer = null;
                if (file.IsTextFile()) 
                {
                    fileAnalzer = new TextFileAnalyzer();
                }

            }
        }
    }
}
