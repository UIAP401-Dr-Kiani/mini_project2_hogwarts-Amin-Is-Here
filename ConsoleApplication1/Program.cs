using System ;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace ConsoleApplication1
{
    internal class Program
    {
        public static List<Human> StudentFile()
        {
            dynamic StudentJsonFile =
                JsonConvert.DeserializeObject<List<Human>>(File.ReadAllText("JSON_DATA.json"));
            return StudentJsonFile;
        }
        public static void MainPage()
        {
            Console.WriteLine("********Wellcome To Hogwars************ ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Sign In As Dumbledore (D)");
            Console.WriteLine("Sign In As Ticher (T)");
            Console.WriteLine("Sign In As Student (S)");
            Console.ReadLine();



        }
        
        
        
        public static void Main(string[] args)
        {
            StudentFile();
            Console.ReadKey();

        }
        
    }
}