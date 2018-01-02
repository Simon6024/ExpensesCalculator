using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Configuration;
namespace ExpensesCalculator.Control
{

    public class CsvReader
    {

        char delimitor = ',';

        public List<FileContent> GetAllFilesContent()
        {
            var path = ConfigurationManager.AppSettings["CsvPath"];
            List<FileContent> AllFileContent = new List<FileContent>();

            foreach (string filePath in Directory.GetFiles(path))
            {
                Console.WriteLine($"Loading file in memory: {filePath}...");
                AllFileContent.Add(new FileContent()
                {
                    FileName = Path.GetFileName(filePath)
                        ,
                    Content = GetFileContent(filePath)
                });
            }

            return AllFileContent;
        }

        public List<String[]> GetFileContent(string file)
        {
            var lines = File.ReadAllLines(file).Select(a => a.Split(delimitor)).ToList();
            return lines;
        }
    }

    public class FileContent
    {
        public string FileName { get; set; }
        public List<String[]> Content { get; set; }
    }
}