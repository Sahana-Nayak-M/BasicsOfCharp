using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsofCharp
{
    class TeachersAssignment
    {

        public void TeacherData()
        {
            bool flag = true;
            string str=null;
            string teacher = null;
            Console.WriteLine("Teacher Information System");
            while (flag)
            {

                Console.WriteLine("Enter options for specified functions");
                Console.WriteLine("1.Add\n2.Update\n3.Delete\n4.Display\n5.Exit");
                str=Console.ReadLine();
                str = str.ToLower();
                switch (str)
                {
                    case "1":
                    case "add":
                    case "1.add":
                        Console.WriteLine("Enter in format (ID,Name,Class and Section)");
                        teacher = Console.ReadLine();
                        WriteRecord(teacher);
                        Console.WriteLine("Added teacher Info");
                        break;
                    case "2":
                    case "update":
                    case "2.update":
                        Console.WriteLine("Enter in format (ID,Name,Class and Section) for record to be updated");
                        teacher = Console.ReadLine();
                        UpdateFile(teacher);
                        break;
                    case "3":
                    case "delete":
                    case "3.delete":
                        Console.WriteLine("Enter teacher ID to delete\n");
                        string id = Console.ReadLine();
                        DeleteInfo(id);
                        Console.WriteLine("Deleted teacher Info\n");
                        ReadFile();
                        break;
                    case "4":
                    case "display":
                    case "4.display":
                        Console.WriteLine("Enter teacher ID to display");
                        string id1 = Console.ReadLine();

                        ReadFileID(id1);
                        
                        break;
                    case "5":
                    case "exit":
                    case "5.exit":
                        Console.WriteLine("Exiting..");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option, Please enter valid option");
                        break;
                }
            }
        }
        public void WriteRecord(string content)
        {
            content = "\n" + content;
            File.AppendAllText("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn and Mosh Angular//FileIOPractice.txt", content);
        }
        public void UpdateFile(string content)
        {
            string[] contents = File.ReadAllLines("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn and Mosh Angular//FileIOPractice.txt");
            string id = content.Split(",")[0];
            string sn = null;
            for (int i = 0; i < contents.Length; i++)
            {
                string iD = contents[i].Split(",")[0];

                //except entered id  all others id's are transferred, (remove that id first from existing) then append new content at last
                if (id==iD)
                {
                    contents[i] = content;              
                   
                }
            }
            File.WriteAllLines("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn and Mosh Angular//FileIOPractice.txt", contents);
            Console.WriteLine("Record is updated");
            ReadFileID(id);
        }
        
        
        
        public void DeleteInfo(string id)
        {
            string[] contents = File.ReadAllLines("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn and Mosh Angular//FileIOPractice.txt");
            for (int i = 0; i < contents.Length; i++)
            {
                string iD = contents[i].Split(",")[0];
                //except entered id  all others id's are transferred
                if (id == iD)
                {
                    contents[i] = "";

                }

            }
            File.WriteAllLines("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn and Mosh Angular//FileIOPractice.txt", contents);

        }
        public void ReadFile()
        {
            string[] contents = File.ReadAllLines("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn and Mosh Angular//FileIOPractice.txt");
            foreach (string str in contents)
                Console.WriteLine(str);
        }
        public void ReadFileID(string ID)
        {
            string[] contents = File.ReadAllLines("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn and Mosh Angular//FileIOPractice.txt");
            foreach (string str in contents)
            {
                string id = str.Split(",")[0];
                if (id == ID)
                {
                    Console.WriteLine("Please find the info\n");
                    Console.WriteLine(str);
                    return;
                }
                
            }
            Console.WriteLine("Record not found");
        }
    }
}
