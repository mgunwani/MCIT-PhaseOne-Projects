/*using System;
using System.IO;

namespace FileHandlingConcepts
{
    class FileOperations
    {
        public void WriteData()
        {
            FileStream fs = new FileStream(
                "E:\\MCIT-DotNet-Phase-One-Projects\\Files\\test.txt",
                FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.Write("Write Message : ");
            string message = Console.ReadLine();
            sw.WriteLine(message);
            Console.WriteLine("The Content written to the file successfully.");
            sw.Close();
            fs.Close();
        }
        public void AppendData()
        {
            try
            {
                using (FileStream fs = new FileStream("E:\\MCIT-DotNet-Phase-One-Projects\\Files\\test.txt", FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        Console.Write("Write Message : ");
                        string message = Console.ReadLine();
                        sw.WriteLine(message);
                        Console.WriteLine("The Content append to the file successfully.");
                    }
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ReadData()
        {
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(
                "E:\\MCIT-DotNet-Phase-One-Projects\\Files\\test.txt",
                FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                sr.BaseStream.Seek(10, SeekOrigin.Begin);
                string str = sr.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr.Close();
                fs.Close();
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FileOperations fileOperations = new FileOperations();
            // fileOperations.WriteData();
            // fileOperations.AppendData();
            fileOperations.ReadData();

            Console.ReadKey();
        }
    }
}
*/