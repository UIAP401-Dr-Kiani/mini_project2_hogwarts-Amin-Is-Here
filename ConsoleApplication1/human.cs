namespace ConsoleApplication1
{
    public class Human
    {
        public string name { get; set; }
        public string family { get; set; }
        public string dateOfBirth { get; set; }
        public string gender { get; set; }
        public string father { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public type TypeOfBlood { get; set; }
        public enum type
        {
            HalfBlood,
            PureBlood,
            MuggleBlood
        }
        public string role { get; set; }
    }
}