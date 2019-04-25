using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("Géza", DateTime.Now, Gender.Male);
            Console.WriteLine(person1.ToString());
            Console.WriteLine("\n");

            Employee employee1 = new Employee("Zoli", DateTime.Now, Gender.Male, 10000, Profession.Necromancer);
            Console.WriteLine(employee1.ToString());

            Room room1 = new Room(employee1, 1);
            Console.WriteLine("\n");
            Console.WriteLine(room1.employee.ToString());
            Console.WriteLine(room1.GetRoomNumber());

            Console.ReadLine();

        }

        class Person
        {

            protected String name;
            protected DateTime birthDate;
            protected Gender gender;

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

        class Employee: Person {

            private int salary;
            private Profession profession;

            public Employee(string name, DateTime birthDate, Gender gender, int salary, Profession profession) : base(name, birthDate, gender)
            {
                this.profession = profession;
                this.salary = salary;
            }


            override
            public String ToString()
            { return name + " " + gender + " " + birthDate + " " + profession + " " + salary; }

        }

        class Room {

            public Employee employee;
            private int roomNumber;

            public Room(Employee employee, int roomNumber) {

                this.employee = employee;
                this.roomNumber = roomNumber;
            }

            public int GetRoomNumber() {
                return roomNumber;
            }

        }

        enum Profession {

            Doctor,
            Magician,
            Necromancer,
            Policeman,
            Businessman,
            HR,
            Sales,
            CEO

        }

        enum Gender
        {

            Male,
            Female

        }
    }
}
