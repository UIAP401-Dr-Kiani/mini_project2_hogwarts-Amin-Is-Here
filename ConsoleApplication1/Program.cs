using ConsoleApplication1.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication1
{
    internal class Program
    {
        static List<Student> StudentList = new List<Student>();
        static List<Teacher> TeacherList = new List<Teacher>();
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
            Console.Clear();
            Console.WriteLine("********Wellcome To Hogwarts************ ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Sign In As Dumbledore (D)");
            Console.WriteLine("Sign In As Ticher (T)");
            Console.WriteLine("Sign In As Student (S)");
            string input = Console.ReadLine();
            if (input == "D")
            {
                Console.Clear();
                DumbledoreSignIn();
            }

            else if (input == "T")
            {
                Console.Clear();
                TicherSignIn();

            }
            else if (input == "S")
            {
                Console.Clear();
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
                WriteAndSendLettersToStudents();
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
            if (File.Exists("Ticher.txt"))
            {
                File.Delete("Ticher.txt");
            }
            for (int i = 0; i < Siginname.Count; i++)
            {
                if (Siginname[i].role == "teacher" && Siginname[i].username == input && Siginname[i].password == input2)
                {
                    using (var Writer = new StreamWriter("Ticher.txt"))
                    {
                        Writer.WriteLine(Siginname[i].name);
                    }
                    TeacherPage();
                }

            }
            Console.WriteLine("WrongInput!!!!!");

        }

        public static void TeacherPage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("_-_-_-_-_-_-WELLCOME TEACHER-_-_-_-_-_-");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Choose Lessons (c)");
            Console.WriteLine("2) Exit (e)");
            Console.ResetColor();
            string input = Console.ReadLine();
            if (input== "c")
            {
                TeacherLesson();
            }
            else if (input == "e")
            {
                MainPage();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Input!!!");
                Console.ResetColor();
            }
        }

        public static void TeacherLesson()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                     Wellcome " + File.ReadAllText("Ticher.txt"));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please Chooes Your Abillity");
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Teach In 1 class (1)");
            Console.WriteLine("Teach In 2 classes (2)");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Exit (e)");
            Console.ResetColor();
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.Clear();
                TeacherLesson();

            }
            else if (input == "2")
            {
                Console.Clear();
                Teacher2Lessons();

            }
            else if (input == "e")
            {
                Console.Clear();
                TeacherPage();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wronng Input!!!");
                Console.ResetColor();
            }
        } 
        public static void Teacher2Lessons()
        {

            while(true) 
            {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("              <<choose lessons>>");
                        Console.ResetColor();
                        Console.WriteLine("Lessons : chemistry(c) , magic(m) , Plant Biology (o) , sport(s) , exit(e).");
                        Console.WriteLine("then choose your start and end time");
                        Console.WriteLine("Times : 8-10 , 10-12  , 14-16 , 16-18");
                        Console.Write("At first choose your lesson  :");
                        string input1 = Console.ReadLine();
                        if (input1 == "e") 
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("you added all lesson you want.");
                            Console.ResetColor();
                            TeacherPage();
                        }
                        else if (input1 == "c")
                        {
                            Console.Write("Please enter your start time :");
                            string startTime = Console.ReadLine();
                            Console.Write("Please enter your end time :");
                            string endTime = Console.ReadLine();
                            TeacherList.Add(new Teacher
                            {
                                Name = File.ReadAllText("Ticher.txt"),
                               TwoClasses = true,
                                Lesson = "Chemistry",
                                Start= startTime,
                                End = endTime
                            });
                        }
                        else if(input1 == "m")
                        {
                            Console.Write("Please enter your start time :");
                            string startTime = Console.ReadLine();
                            Console.Write("Please enter your end time :");
                            string endTime = Console.ReadLine();
                            TeacherList.Add(new Teacher
                            {
                                Name = File.ReadAllText("Ticher.txt"),
                                TwoClasses = true,
                                Lesson = "magic",
                                Start= startTime,
                                End = endTime
                            });
                        }
                        else if (input1 == "p")
                        {
                            Console.Write("Please enter your start time :");
                            string startTime = Console.ReadLine();
                            Console.Write("Please enter your end time :");
                            string endTime = Console.ReadLine();
                            TeacherList.Add(new Teacher
                            {
                                Name = File.ReadAllText("Ticher.txt"),
                                TwoClasses = true,
                                Lesson = "Plant Biology ",
                                Start= startTime,
                                End = endTime
                            });
                        }
                        else if (input1 == "s")
                        {
                            Console.Write("Please enter your start time :");
                            string startTime = Console.ReadLine();
                            Console.Write("Please enter your end time :");
                            string endTime = Console.ReadLine();
                            TeacherList.Add(new Teacher
                            {
                                Name = File.ReadAllText("Ticher.txt"),
                                TwoClasses = true,
                                Lesson = "sport",
                                Start= startTime,
                                End = endTime
                            });
                        }
                        else 
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("you enter wrong key please try again.");
                            Console.ResetColor(); 
                            TeacherLesson(); 
                        } 
            } 
        }
        public static void TeacherOneLesson()
        {
            
                     while (true)
                     {
                         Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("choose lesson :");
                        Console.ResetColor();
                        Console.WriteLine("lessons : chemistry(c) , magic(m) , occultims(o) , sport(s) , exit(e).");
                        Console.Write("Please choose your lesson :");
                        string input = Console.ReadLine();
                        if (input == "e")
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("you added all lessons.");
                            Console.ResetColor();
                            TeacherPage();
                        }
                        else if (input == "c")
                        {
                            Console.Write("Please enter your start time :");
                            string StartTime = Console.ReadLine();
                            Console.Write("Please enter your end time :");
                            string EndTime = Console.ReadLine();
                            int num = 0;
                            foreach(var teacher in TeacherList)
                            {
                                if(teacher.Name == File.ReadAllText("Ticher.txt") && teacher.Start == StartTime && teacher.End == EndTime)
                                {
                                    num++;
                                }
                            }
                            if(num >= 1)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("you can not choose 2 lesson in one time.");
                                Console.ResetColor();
                                TeacherOneLesson();
                            }
                            else
                            {
                                TeacherList.Add(new Teacher
                                {
                                    Name =File.ReadAllText("Ticher.txt") ,
                                    TwoClasses= true,
                                    Lesson = "Chemistry",
                                    Start = StartTime,
                                    End= EndTime
                                });
                            }
                            
                        }
                        else if (input == "m")
                        {
                            Console.Write("Please enter your start time :");
                            string StartTime = Console.ReadLine();
                            Console.Write("Please enter your end time :");
                            string EndTime = Console.ReadLine();
                            int num = 0;
                            foreach(var teacher in TeacherList)
                            {
                                if(teacher.Name == File.ReadAllText("Ticher.txt") && teacher.Start == StartTime && teacher.End == EndTime)
                                {
                                    num++;
                                }
                            }
                            if(num >= 1)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("you can not choose 2 lesson in one time.");
                                Console.ResetColor();
                                TeacherOneLesson();
                            }
                            else
                            {
                                TeacherList.Add(new Teacher
                                {
                                    Name =File.ReadAllText("Ticher.txt") ,
                                    TwoClasses= true,
                                    Lesson =  "magic",
                                    Start = StartTime,
                                    End= EndTime
                                });
                            }
                            
                        }
                        else if (input == "p")
                        {
                            Console.Write("Please enter your start time :");
                            string StartTime = Console.ReadLine();
                            Console.Write("Please enter your end time :");
                            string EndTime = Console.ReadLine();
                            int num = 0;
                            foreach(var teacher in TeacherList)
                            {
                                if(teacher.Name == File.ReadAllText("Ticher.txt") && teacher.Start == StartTime && teacher.End == EndTime)
                                {
                                    num++;
                                }
                            }
                            if(num >= 1)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("you can not choose 2 lesson in one time.");
                                Console.ResetColor();
                                TeacherOneLesson();
                            }
                            else
                            {
                                TeacherList.Add(new Teacher
                                {
                                    Name =File.ReadAllText("Ticher.txt") ,
                                    TwoClasses= true,
                                    Lesson =  "Plant Biology ",
                                    Start = StartTime,
                                    End= EndTime
                                });
                            }
                            
                        }
                        else if (input == "s")
                        {
                            Console.Write("Please enter your start time :");
                            string StartTime = Console.ReadLine();
                            Console.Write("Please enter your end time :");
                            string EndTime = Console.ReadLine();
                            int num = 0;
                            foreach(var teacher in TeacherList)
                            {
                                if(teacher.Name == File.ReadAllText("Ticher.txt") && teacher.Start == StartTime && teacher.End == EndTime)
                                {
                                    num++;
                                }
                            }
                            if(num >= 1)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("you can not choose 2 lesson in one time.");
                                Console.ResetColor();
                                TeacherOneLesson();
                            }
                            else
                            {
                                TeacherList.Add(new Teacher
                                {
                                    Name =File.ReadAllText("Ticher.txt") ,
                                    TwoClasses= true,
                                    Lesson =  "sport",
                                    Start = StartTime,
                                    End= EndTime
                                });
                            }
                            
                        }
                        else
                        {
                            Console.Clear ();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong input !!!");
                            Console.ResetColor ();
                            TeacherOneLesson();
                        }
                    }

        }

        public static void TeacherShow()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Available Teachers ");
            Console.ResetColor();
            foreach (var teacher in TeacherList)
            {
                Console.WriteLine($"Teacher name :{teacher.Name}");
                Console.WriteLine($"Lesson :{teacher.Lesson}");
                Console.WriteLine($"Satrt time :{teacher.Start} , End time :{teacher.End}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("_______________________________________");
                Console.ResetColor();
            }
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
            if (File.Exists("Student.txt"))
            {
             File.Delete("Student.txt");   
            }
            for (int i = 0; i < Siginname.Count; i++)
            {
                if (Siginname[i].role == "student" && Siginname[i].username == input && Siginname[i].password == input2)
                {
                    using (var Writer = new StreamWriter("Student.txt"))
                    {
                        Writer.WriteLine(Siginname[i].name);
                    }
                    StudentMainPage();
                }

            }
            
            Console.WriteLine("WrongInput!!!!!");
            MainPage();

        }

        public static void StudentMainPage()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                     Wellcome " + File.ReadAllText("Student.txt"));
            Console.ResetColor();
            Console.WriteLine("1) Select unit (s)");
            Console.WriteLine("2) Personal page (p)");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("3) Exit (3)");
            Console.ResetColor();
            string input = Console.ReadLine();
            if (input == "s")
            {
                Console.Clear();
                
            }
            else if (input== "p")
            {
                Console.Clear();
            }
            else if (input == "e")
            {
                Console.Clear();
                
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Input!!! ");
                Console.ResetColor();
                StudentMainPage();
            }
            

        }

        public static void SelectUnit()
        {
            int Units = 0;
            Console.WriteLine("Hello " + File.ReadAllText("Student.txt"));
            Console.WriteLine("List Of Lessons and Their Units");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("1 ) Magic : 3 Units ");
            Console.WriteLine("Key to choose : (m) ");
            Console.WriteLine("___________________________________");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("2 ) Plant Biology : 3 Units ");
            Console.WriteLine("Key to choose : (p) ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("3 ) Chemistry : 2 Units ");
            Console.WriteLine("Key to choose : (c) ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("4 ) Sports : 1 Unit ");
            Console.WriteLine("Key to choose : (s) ");
            Console.ResetColor();
            
            
            Console.WriteLine("Exit(e)");
            Console.WriteLine("List of teacher :");
            TeacherShow();
            //ChooseLesson();   
        }


        public static void Main(string[] args)
        {
            Students();
            Teachers();
            MainPage();
            Console.WriteLine();
        }

    }
}