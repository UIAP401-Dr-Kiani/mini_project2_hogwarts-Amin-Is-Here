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

            Console.Write("Your Dorm information is :");
            Console.WriteLine(DormInformation);
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

            }
            else
            {
                Console.WriteLine("Wrong Input !!!!!!");
                DumbledoreSignIn();

            }



        }
        public static void DumbledorePage()
        {
            Console.WriteLine("                wellcome Dumbledore ");
            Console.WriteLine("1)");
             
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
            MainPage();
            Console.WriteLine();
        }

    }
}