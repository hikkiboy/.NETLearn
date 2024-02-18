using System.IO;
namespace FilesCsharp

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\hikki\Desktop\File1.txt";
            string targetPath = @"C:\Users\hikki\Desktop\File2.txt";

            try
            {
                FileInfo fileinfo = new FileInfo(sourcePath);
                fileinfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has ocurred: "+ ex.Message);
            }
        }
    }
}
