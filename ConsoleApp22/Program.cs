using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    abstract class Person
    {
        public string Name;
        public string Surname;
        public int Age
        {
            get
            {
                return Age;
            }
            set
            {
                if (value < 0 && value < 18)
                {
                    Console.WriteLine("yas uygun deyil");
                }

                else
                {
                    Age = value;

                }
            }


        }
        class Employee : Person
        {
            public Employee(string Name, string Surname, int Age)
            {
                this.Name = Name;
                this.Surname = Surname;
                this.Age = Age;
                Console.WriteLine(Name + Surname + Age);
            }
            public double SalaryOfHour
            {
                get
                {
                    return SalaryOfHour;
                }
                set
                {
                    if (value < 0 && value > 8)
                    {
                        Console.WriteLine("is sahati uygun deyil");
                    }
                    else
                    {
                        SalaryOfHour = value;
                    }
                }
            }
            public double WorkingHour { get; set; }
            public Employee(double SalaryOfHour, double WorkingHour)
            {
                this.SalaryOfHour = SalaryOfHour;
                this.WorkingHour = WorkingHour;
            }
            static double CalculateSalary(double SalaryOfHour, double WorkingHour)
            {
                double MonSalry;
                MonSalry = SalaryOfHour * WorkingHour;
                return MonSalry;

            }

        }
        class Student : Person
        {
            public string Name;
            public string Surname;
            public int Age
            {
                get
                {
                    return Age;
                }
                set
                {
                    if (value < 6 && value > 20)
                    {
                        Console.WriteLine("yas  uygun deyil");
                    }
                    else
                    {
                        Age = value;
                    }
                }
            }
            public double QIRank
            {
                get
                {
                    return QIRank;
                }
                set
                {
                    if (value < 0 && value > 100)
                    {
                        Console.WriteLine("Bal uygun deyil");
                    }
                    else
                    {
                        QIRank = value;
                    }
                }
            }
            public double LanguageRank
            {
                get
                {
                    return LanguageRank;
                }
                set
                {
                    if (value < 0 && value > 100)
                    {
                        Console.WriteLine("Bal uygun deyil");
                    }
                    else
                    {
                        LanguageRank = value;
                    }
                }
            }
            public Student(string Name, string Surname, int Age, double QIRank, double LanguageRank)
            {
                this.Name = Name;
                this.Surname = Surname;
                this.Age = Age;
                this.QIRank = QIRank;
                this.LanguageRank = LanguageRank;

            }
            static void ExamResult(double QIRank, double LanguageRank)
            {
                if (QIRank + LanguageRank < 120)
                {
                    Console.WriteLine("sinfde qaldin");
                }
                else
                {
                    Console.WriteLine("tebrikler ugurla kecdiniz");
                }
            }
        }
    }

}

