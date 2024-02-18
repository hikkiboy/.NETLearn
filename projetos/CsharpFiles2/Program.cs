using System.IO;
using System.Collections.Generic;
namespace CsharpFiles2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\hikki\Desktop\Xadrez";

            try
            {
                IEnumerable<string> folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\newfolder");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            

        }
    }
}
