using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class AuthorizedPersons : Human

    {

        public enum Pet { Rat, Cat, Owl }
        public Pet pet { get; set; }
        public Group group { get; set; }
        public bool HavingSuitcase;

        public enum Job
        {
            teacher,
            student
        }

        public Job job { get; set; }

        public string Letter { get; set; }

        public List<string> ReceivedLetter = new List<string>();

    }

}
