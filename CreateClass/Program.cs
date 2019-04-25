using System;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Kovacs = new Employee("Géza", DateTime.Now, Gender.Male, 1000, Profession.Necromancer);
            Kovacs.Room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.Number = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString() + " " + "Room number: " + Kovacs2.Room.GetRoomNumber());
            Console.ReadKey();

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

        class Employee: Person, ICloneable {

            private int salary;
            private Profession profession;

            public Employee(string name, DateTime birthDate, Gender gender, int salary, Profession profession) : base(name, birthDate, gender)
            {
                this.profession = profession;
                this.salary = salary;
            }

            public Room Room { get; internal set; }

            public object Clone()
            {
                return this.MemberwiseClone();
            }

            override
            public String ToString()
            { return name + " " + gender + " " + birthDate + " " + profession + " " + salary; }

        }

        class Room {

            public Employee employee;
            private int roomNumber;

            public Room(int roomNumber) {

                this.roomNumber = roomNumber;
            }

            public int Number { get; internal set; }

            public int GetRoomNumber() {
                return roomNumber;
            }

        }

        interface ICloneable {

            object Clone();

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
