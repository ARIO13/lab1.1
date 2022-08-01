using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace GAZ.CSCourse.TestConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;//create string
            StreamReader sr = new StreamReader("c:\\users\\admin\\documents\\visual studio 2010\\Projects\\GAZ.CSCourse.TestConsoleApplication\\GAZ.CSCourse.TestConsoleApplication\\DataFile.txt");
             
             while ((line = sr.ReadLine()) != null) //enter line value
            {
                line = line.Replace(",","y:");//format
                line = "x:" + line;//merge 
                Console.WriteLine(line);//out line
                            
            }
             

        }
    }
}
