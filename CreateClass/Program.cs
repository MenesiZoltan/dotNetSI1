using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("Géza", DateTime.Now, Gender.Male);
            Console.WriteLine(person1.ToString());
            Console.Write("IS THIS PRINTING AT ALL?");
            Console.ReadLine();
        }

        class Person
        {

            private String name;
            private DateTime birthDate;
            private Gender gender;

            public Person(String name, DateTime birthDate, Gender gender)
            {

                this.name = name;
                this.birthDate = birthDate;
                this.gender = gender;

            }

            override
            public string ToString()
            {
                return name + " " + gender + " " + birthDate;
            }

        }

        enum Gender
        {

            Male,
            Female

        }
    }
}
