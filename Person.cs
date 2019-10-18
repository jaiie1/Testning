using System;

namespace Test
{
    public class Person
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public DateTime Birthdate { get; private set; }
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public int Age
        {
            get
            {
                var timeSpam = DateTime.Today - Birthdate;
                var years = timeSpam.Days / 365;

                return years;
            }
        }

        
    }
}