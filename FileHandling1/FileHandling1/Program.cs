using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            addRecord("124", "Mercy", "56", "myfile.txt");
        }

        public static void addRecord(string ID, string name , string age , string filename)
        {
            try
            {
               using(System.IO.StreamWriter file = new System.IO.StreamWriter("D:\\myfile.txt" , true))
                {
                    file.WriteLine(ID + "," + name + "," + age);
                }
            }
            catch(Exception ex)
            {
                throw new ApplicationException("This program did an opposie :", ex);
            }
        }
    }
}
