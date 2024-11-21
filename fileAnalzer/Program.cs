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
            IFileAnalyzer fileAnalzer = null;

            foreach (var file in filenams)
            {

                if (file.IsTextFile()) 
                {
                    fileAnalzer = new TextFileAnalyzer();

                    fileAnalzer.AnalyzeFile(file);

                    var results = ((FileAnalyzer)fileAnalzer).GetResulte();

                    Console.WriteLine($"File Name : {file.Name}");
                    Console.WriteLine($"Word Count : {results.WordCount}");
                    Console.WriteLine($"Line Count : {results.LineCount}");
                     Console.WriteLine($"charcter Count : {results.CharachterCount}");
                }
               else if (file.IscsvFile()) 
                {
                    fileAnalzer = new CSVFileAnalyzer();

                    fileAnalzer.AnalyzeFile(file);

                    var results = ((FileAnalyzer)fileAnalzer).GetResulte();

                    Console.WriteLine($"File Name : {file.Name}");
                    Console.WriteLine($"Field Count : {results.FieldCount}");
                 }
                 
                {
                    
                }
            }
              
        }
    }
}
