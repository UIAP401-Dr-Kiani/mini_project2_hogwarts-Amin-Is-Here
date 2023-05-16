using System ;
using System.Collections.Generic;
using System.IO;
using ConsoleApplication1.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace ConsoleApplication1
{
    internal class Program
    {
        public  static int DormInformation = 110;
        public  static int DormInformationW = 110;
        public static List<Human> StudentFile()
        {
            dynamic StudentJsonFile =
                JsonConvert.DeserializeObject<List<Human>>(File.ReadAllText("JSON_DATA.json"));
            return StudentJsonFile;
        }

        public static void DormMan()
        {
            DormInformation++;
            if (DormInformation%10>3 && DormInformation%100>53)
            {
                DormInformation += 100;
                DormInformation -= 44;
            }
            else if (DormInformation%10>3 && DormInformation%100<53)
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
            if (DormInformationW%10>3 && DormInformationW%100>53)
            {
                DormInformationW += 100;
                DormInformationW -= 44;
            }
            else if (DormInformationW%10>3 && DormInformationW%100<53)
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
                
            }
            
            else if (input == "T")
            {
                
            }
            else if (input == "S")
            {
                
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
            string  input = Console.ReadLine();
            Console.Write("PassWord : ");
            string input2 = Console.ReadLine();
            if (input == Dumbledore.UserName && input2 == Dumbledore.PassWord)
            {
                
            }
            


        } 
        
        
        public static void Main(string[] args)
        {
            StudentFile();
            
            Console.ReadKey();
        }
        
    }
}