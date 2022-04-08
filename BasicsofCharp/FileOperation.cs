using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BasicsofCharp
{
    public class FileOperation
    {
        public void WriteFile()
        {
            string content = "ID,Name,Dept";
            File.WriteAllText("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn//FileIOPractice.txt", content);
        }
        public void UpdateFile()
        {
            string employee = "\n1,Sahana,QE";
            File.AppendAllText("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn//FileIOPractice.txt", employee); 
        }

        public void DeleteFile()
        {
            if (File.Exists("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn//FileIOPractice.txt"))
                File.Delete("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn//FileIOPractice.txt");
        }
        public void ReadFile()
        {
            string content = File.ReadAllText("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn//FileIOPractice.txt");
            Console.WriteLine(content);
            string[] contents = File.ReadAllLines("C://Users//Sahana_Nayak_M//Documents//FSD Simplilearn//FileIOPractice.txt");
            foreach (string str in contents)
                Console.WriteLine(str);
        }
    }
}
