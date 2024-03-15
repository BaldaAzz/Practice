using System;

namespace N_1
{
    class Student
    {
        private string name;
        protected double s;

        public Student(string name, double s)
        {
            this.name = name;
            this.s = s;
        }

        public decimal Scholarship()
        {
            return 300000 + 10000 * (Convert.ToDecimal(this.s) - 5);
        }
    }

    class Magistr: Student
    {   
        private string speciality;

        public Magistr(string name, double s, string speciality): base(name, s)
        {
            this.speciality = speciality;
        }

        public decimal Scholarship(decimal m)
        {
            return 300000 + 10000 * (Convert.ToDecimal(this.s) - 5) + m;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s =  new("Олег", 7.3);
            Console.WriteLine($"Степеньдия: {s.Scholarship()}");

            Magistr m = new("Другой Олег", 9.1, "биология");
            Console.WriteLine($"Степеньдия: {m.Scholarship(1000)}");
        }
    }
}