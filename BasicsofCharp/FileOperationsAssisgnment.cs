using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCharp
{
    class FileOperationsAssisgnment
    {

        public void StudentData()
        {
            bool flag = true;
            string str=null;
            string employee = null;
            Console.WriteLine("Student Information System");
            while (flag)
            {

                Console.WriteLine("Enter options for specified functions");
                Console.WriteLine("1.Add\n2.Update\n3.Delete\n4.Display\n5.Exit");
                str=Console.ReadLine();
                switch (str)
                {
                    case "1":
                        Console.WriteLine("Adding student Info,Enter in format (ID,Name,Dept)");
                        employee = Console.ReadLine();
                        UpdateFile(employee);
                        break;
                    case "2":
                        Console.WriteLine("Editing student Info");

                        break;
                    case "3":
                        Console.WriteLine("Deleting student Info");

                        break;
                    case "4":
                        Console.WriteLine("Displaying student Info");
                        break;
                    case "5":
                        Console.WriteLine("Exiting..");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option, Please enter valid option");
                        break;
                }
            }
        }
        public void WriteFile()
        {
            string content = "ID,Name,Dept";
            File.WriteAllText("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn//FileIOPractice.txt", content);
        }
        public void UpdateFile(string employee)
        {
            File.AppendAllText("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn//FileIOPractice.txt", employee);
        }
        //public void DeleteLine()
        //{
        //    if (File.Exists("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn//FileIOPractice.txt"))
        //        File.Delete("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn//FileIOPractice.txt");
        //    File.D
        //}
        public void DeleteFile()
        {
            if (File.Exists("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn//FileIOPractice.txt"))
                File.Delete("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn//FileIOPractice.txt");
        }
        public void ReadFile()
        {
            string[] contents = File.ReadAllLines("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn//FileIOPractice.txt");
            foreach (string str in contents)
                Console.WriteLine(str);
        }
    }
}
