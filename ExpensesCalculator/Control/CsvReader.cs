using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Configuration;
namespace ExpensesCalculator.Control
{

    public class CsvReader
    {
        static char delimitor = ',';
        static string path = ConfigurationManager.AppSettings["CsvPath"];

        public List<FileContent> GetAllFilesContent()
        {
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

        public void Archive(string fileName)
        {
            File.Move(path + fileName, path + "Archive\\" + fileName + DateTime.Today.ToString("yyyy-MM-dd"));
        }
    }

    public class FileContent
    {
        public string FileName { get; set; }
        public List<String[]> Content { get; set; }
    }
}