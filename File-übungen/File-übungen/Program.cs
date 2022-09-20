using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_übungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileInfo fi = new FileInfo("T:/WKH_EXC/Trash/cbec/BMI-data.csv");
            ////fi.CopyTo("C:/010Pojects/014Uebungen2/File-übungen/meine_datei123.csv");

            ////FileInfo fi = new FileInfo("C:/010Pojects/014Uebungen2/File-übungen/meine_datei123.csv");
            ////fi.Delete();

            //Console.WriteLine("Geb mir den Pfad an, wohin die Datei geschrieben werden soll!");
            //string path = Console.ReadLine();

            //DirectoryInfo di = new DirectoryInfo(path);

            //while (di.Exists == false)
            //{
            //    Console.WriteLine("Dein Pfad existiert nicht, gib mir einen neuen!");
            //    path = Console.ReadLine();
            //    di = new DirectoryInfo(path);
            //}

            //path.Replace("\\", "\\\\");

            //Console.WriteLine("Wie soll die Datei heißen?");

            //string filename = Console.ReadLine();




            //fi.CopyTo(path + "\\" + filename);

            //FileInfo fi = new FileInfo("T:/WKH_EXC/Trash/cbec/BMIS-data.csv");

            //if (fi.Exists)
            //{
            //    fi.CopyTo("C:\\010Pojects\\014Uebungen2\\File - übungen");

            //}

            string path = @"C:\010Pojects\014Uebungen2\File-übungen\bizzii.csv";

            StreamReader sr = new StreamReader(path);
            List<string[]> einträge = new List<string[]>();
            //Remove Header
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                einträge.Add(sr.ReadLine().Split(';'));                
            }
            
            for (int age = 18; age < 101; age++)
            {
                using (StreamWriter sw = new StreamWriter($@"C:\010Pojects\014Uebungen2\File-übungen\Gewichte_{age}.csv"))
                {

                    for (int i = 0; i < einträge.Count; i++)
                    {
                        if (Convert.ToInt32(einträge[i][2]) == age)
                        {
                            sw.WriteLine(string.Join(";", einträge[i]));
                            Console.WriteLine(string.Join("\t", einträge[i]));
                        }
                    }
                }
            }
            
            Console.ReadKey();
        }
    }
}
