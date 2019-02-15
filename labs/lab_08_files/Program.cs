using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace lab_08_files
{
    class Program
    {
        static void Main(string[] args)
        {
            //read file
            string data01 = File.ReadAllText("file.txt");
            WriteLine(data01);
            // add encoding (optional)
            string data02 = File.ReadAllText("file.txt", Encoding.UTF8);
            Console.WriteLine("\n\n\n" + Environment.NewLine + data02);

            Console.WriteLine($"\n\n\n {data02}");

            Console.WriteLine($"\n\n\n {"hi", -20}{"there",-20}");
            Console.WriteLine($"\n\n\n {"how",-20}{"are",-20}");
            Console.WriteLine($"\n\n\n {"you",-20}{"?",-20}");

            //read as array
            string[] data03 = File.ReadAllLines("file.txt");
            Console.WriteLine("\n\nReading as array.\n\n");
            Console.WriteLine(data03[0]);

            //write data
            Console.WriteLine("\nCreate new file\n");
            File.WriteAllText("file2.txt", "here is \nsome \ndata");
            Console.WriteLine(File.ReadAllText("file2.txt"));


            Console.WriteLine("\nNow write an array to text\n");
            File.WriteAllLines("file3.txt", data03);
            Console.WriteLine("\nAnd read it back\n");
            Console.WriteLine(File.ReadAllText("file3.txt"));


            // copy file
            File.Copy("file.txt", "copyoffile1.txt", true); //overwrite true

            // delete file
            File.Delete("copyoffile1.txt");

            Console.WriteLine("\nDoes my file exist?\n");
            Console.WriteLine(File.Exists("file.txt"));

            Console.WriteLine(File.GetCreationTime("file.txt"));
            Console.WriteLine(File.GetLastWriteTime("file.txt"));

            //EXTRA INFO
            var fileinfo = new FileInfo("file.txt");
            Console.WriteLine(fileinfo.DirectoryName);
            Console.WriteLine(fileinfo.Extension);

            //directory
            Directory.CreateDirectory("folderA");
            Directory.CreateDirectory("folderB");
            Directory.Delete("folderB");
            File.Create("folderA/abc.txt");
            var fileArray = Directory.GetFiles("folderA");
            Console.WriteLine(fileArray[0]);

        }
    }
}
