using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(@"C:\MyFile", "NewFile.txt");

            NewFile();
            NewFile2();
            
        }

        static void NewFile()
        {
            FileInfo file =
                new FileInfo(@"NewFile.txt");

            FileStream fs =
                file.Create();
            fs.Close();
        }
        static void NewFile2()
        {
            FileInfo file =
                new FileInfo("NewFile2.txt");

            using (FileStream fs =
                file.Open(FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default))
                {
                    sw.Write("Soemf");
                }
            }

            StreamWriter srw = new StreamWriter("NewFile2.txt");
             

        }
        static void NewFile3(FileInfo file)
        {
            file.CopyTo(@"C:\Users\акылбекова\Desktop\NewFile2.txt");
        }
    }
}
