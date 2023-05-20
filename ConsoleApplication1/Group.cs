using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Group
    {

        public enum Type1
        {
            Hufflepuff,
            Gryffindor,
            Ravenclaw,
            Slytherin,
        }
        public Type1 type1;
        private int score;
        public int Score { get; set; }
        public List<Group> group;
        public List<Group> play;

    }
}