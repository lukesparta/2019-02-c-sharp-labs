using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_07_files
{
    class Program
    {
        static void Main(string[] args)
        {
            // try - code which can possible crash
            try
            {
                // file read as string
                string data01 = File.ReadAllText("file.txt");
            }
            // we can catch specific sections in the catch block  :  Handling the exception
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Luke says make that file!");
            }
            // finally will alway run regardless
            finally
            {
                Console.WriteLine("and make it quick");
            }
        }
    }
}
