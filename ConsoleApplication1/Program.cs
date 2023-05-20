using ConsoleApplication1.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static int DormInformation = 110;
        public static int DormInformationW = 110;
        public static List<Human> StudentFile()
       {
           dynamic studentJsonFile =
              JsonConvert.DeserializeObject<List<Human>>(File.ReadAllText("JSON_DATA.json"));
            return studentJsonFile;
       }

        public static void Students()
        {
            List<Human> students = new List<Human>();
            List<Human> people = StudentFile();
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].role=="student")

                {
                    students.Add(people[i]);
                }
                
            }
            

        }

        public static void Teachers()
        {
            List<Human> tichers = new List<Human>();
            List<Human> people = StudentFile();
            int j = 0;
            for (int i = 0; i < people.Count-1; i++)
            {
                if (people[i].role=="ticher")

                {
                    tichers.Add(people[i]);
                }
                
            }
        }


        public static void DormMan()
        {
            DormInformation++;
            if (DormInformation % 10 > 3 && DormInformation % 100 > 53)
            {
                DormInformation += 100;
                DormInformation -= 44;
            }
            else if (DormInformation % 10 > 3 && DormInformation % 100 < 53)
            {
                DormInformation += 10;
                DormInformation -= 4;
            }
            
            if (DormInformation == 453)
            {
                Console.WriteLine("Full!!!!");
            }


        }
        public static void DormWoman()
        {
            DormInformationW++;
            if (DormInformationW % 10 > 3 && DormInformationW % 100 > 53)
            {
                DormInformationW += 100;
                DormInformationW -= 44;
            }
            else if (DormInformationW % 10 > 3 && DormInformationW % 100 < 53)
            {
                DormInformationW += 10;
                DormInformationW -= 4;
            }

            Console.Write("Your Dorm information is :");
            Console.WriteLine(DormInformationW);
            if (DormInformation == 453)
            {
                Console.WriteLine("Full!!!!");
            }


        }

        public static void MainPage()
        {
            Console.WriteLine("********Wellcome To Hogwarts************ ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Sign In As Dumbledore (D)");
            Console.WriteLine("Sign In As Ticher (T)");
            Console.WriteLine("Sign In As Student (S)");
            string input = Console.ReadLine();
            if (input == "D")
            {
                DumbledoreSignIn();
            }

            else if (input == "T")
            {
                TicherSignIn();

            }
            else if (input == "S")
            {
                StudentSignIn();
            }
            else
            {
                Console.WriteLine("Wronggggggg Inputttttt !!!!!!!!!!");
                MainPage();
            }






        }

        public static void DumbledoreSignIn()
        {
            Console.WriteLine("Hello Dumbledore Please Sign In");
            Console.Write("UserName :");
            string input = Console.ReadLine();
            Console.Write("PassWord : ");
            string input2 = Console.ReadLine();
            Console.Clear();
            if (input == Dumbledore.UserName && input2 == Dumbledore.PassWord)
            {
                DumbledorePage();

            }
            else
            {
                Console.WriteLine("Wrong Input !!!!!!");
                DumbledoreSignIn();

            }



        }
        public static void DumbledorePage()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("                wellcome Dumbledore ");
            Console.ResetColor();
            Console.WriteLine("1) Write And Send Letters To Students");
            Console.WriteLine("2) ");




            string input = Console.ReadLine();
            if (input=="w")
            {
               WriteAndSendLettersToStudents();
            }

        }

        public static void WriteAndSendLettersToStudents()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("1) Write the letter");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("2) Send the letter");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("3) Exit");
            Console.ResetColor();
           string input= Console.ReadLine();
            if (input== "w")
            {
                WriteLetter();
            }
            else if (input== "s")
            {
                SendLetter();
            }
            else if (input == "e")
            {
                 DumbledorePage();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Input");
                Console.ResetColor();
                WriteAndSendLettersToStudents();
            }

        }
        public static void WriteLetter()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Please compleate every field.");
            Console.ResetColor();
            try
            {
                Console.Write("* Train Number :");
                string TrainNumber = Console.ReadLine();
                Console.Write("* Date Letter :");
                string DateLetter = Console.ReadLine();
                Console.WriteLine("Letters");
                string Letters = Console.ReadLine();
                using (var Writer = new StreamWriter("Massage.txt"))
                {
                    Writer.WriteLine(TrainNumber + "|" + DateLetter + "|" + Letters);
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your massage saved.");
                Console.ResetColor();
                DumbledorePage();
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please try again and write true.");
                Console.ResetColor();
                WriteAndSendLettersToStudents();

            }
        }

        public static void SendLetter()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Write student's name.");
            Console.ResetColor();
            Console.WriteLine("Username : ");
            string input= Console.ReadLine();
            List<Human> studentcheck = StudentFile();
            for (int i = 0; i < studentcheck.Count; i++)
            {
                if (input == studentcheck[i].username)
                    Console.WriteLine(i); 
            }
        }

        public static void TicherSignIn()
        {
            Console.Write("Username :");
            string input = Console.ReadLine();
            Console.Write("Password :");
            string input2 = Console.ReadLine();
            List<Human> Siginname = StudentFile();
            int index = 0;
            int count = 0;
            for (int i = 0; i < Siginname.Count; i++)
            {
                if (Siginname[i].role == "teacher" && Siginname[i].username == input && Siginname[i].password == input2)
                {
                }

            }
            Console.WriteLine("WrongInput!!!!!");

        }
        public static void StudentSignIn()
        {
            Console.Write("Username :");
            string input = Console.ReadLine();
            Console.Write("Password :");
            string input2 = Console.ReadLine();
            List<Human> Siginname = StudentFile();
            int index = 0;
            int count = 0;
            for (int i = 0; i < Siginname.Count; i++)
            {
                if (Siginname[i].role == "student" && Siginname[i].username == input && Siginname[i].password == input2)
                {
                }

            }
            Console.WriteLine("WrongInput!!!!!");

        }

        public static void Main(string[] args)
        {
            Students();
            Console.ReadKey();
           Teachers();
           MainPage();
            Console.WriteLine();
        }

    }
}