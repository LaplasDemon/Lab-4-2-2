using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_19_2
{
    class Program
    {
        class Car
        {
            public string mark { get; set; }
            public string color { get; set; }
            public string numb { get; set; }
            private int year { get; set; }
            private string owner { get; set; }

            public Car()
            {
                this.mark = "Temp Mark";
                this.color = "Temp COlor";
                this.numb = "Temp Numb";
                this.year = 1111;
                this.owner = "Temp Owner";
            }

            public Car(string mr, string c, string n, int y, string ow)
            {
                if (mr.Length <= 0)
                {
                    Console.WriteLine("Wrong mark\n");
                    return;
                }
                else if (c.Length <= 1)
                {
                    Console.WriteLine("Wrong color\n");
                    return;
                }
                else if (n.Length <= 1)
                {
                    Console.WriteLine("Wrong number\n");
                    return;
                }
                else if ((1900 > y) || (y > 2021))
                {
                    Console.WriteLine("Wrong year\n");
                    return;
                }
                else if (ow.Length <= 1)
                {
                    Console.WriteLine("Wrong owner\n");
                    return;
                }
                else
                {
                    this.mark = mr;
                    this.color = c;
                    this.numb = n;
                    this.year = y;
                    this.owner = ow;
                    Console.WriteLine("New car created! - " + this.color + " " + this.mark);
                }
            }

        }


        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            string name, color, number, year, fio;
            Console.WriteLine("Марка - "); name = Console.ReadLine();
            Console.WriteLine("Колiр - "); color = Console.ReadLine();
            Console.WriteLine("Номер - "); number = Console.ReadLine();
            Console.WriteLine("Рiк випуску- "); year = Console.ReadLine();
            Console.WriteLine("Данi про власника - "); fio = Console.ReadLine();
            Car car2 = new Car(name, color, number, Convert.ToInt32(year), fio);
            Console.WriteLine("Марка - "); name = Console.ReadLine();
            Console.WriteLine("Колiр - "); color = Console.ReadLine();
            Console.WriteLine("Номер - "); number = Console.ReadLine();
            Console.WriteLine("Рiк випуску - "); year = Console.ReadLine();
            Console.WriteLine("Данi про власника - "); fio = Console.ReadLine();
            Car car3 = new Car(name, color, number, Convert.ToInt32(year), fio);
            Console.WriteLine("Марка - "); name = Console.ReadLine();
            Console.WriteLine("Колiр - "); color = Console.ReadLine();
            Console.WriteLine("Номер - "); number = Console.ReadLine();
            Console.WriteLine("Рiк випуску - "); year = Console.ReadLine();
            Console.WriteLine("Данi про власника - "); fio = Console.ReadLine();
            Car car1 = new Car(name, color, number, Convert.ToInt32(year), fio);
            Console.WriteLine("Марка - "); name = Console.ReadLine();
            Console.WriteLine("Колiр - "); color = Console.ReadLine();
            Console.WriteLine("Номер - "); number = Console.ReadLine();
            Console.WriteLine("Рiк випуску - "); year = Console.ReadLine();
            Console.WriteLine("Данi про власника - "); fio = Console.ReadLine();
            Car car5 = new Car(name, color, number, Convert.ToInt32(year), fio);
            Console.WriteLine("Марка - "); name = Console.ReadLine();
            Console.WriteLine("Колiр - "); color = Console.ReadLine();
            Console.WriteLine("Номер - "); number = Console.ReadLine();
            Console.WriteLine("Рiк випуску - "); year = Console.ReadLine();
            Console.WriteLine("Данi про власника - "); fio = Console.ReadLine();
            Car car4 = new Car(name, color, number, Convert.ToInt32(year), fio);

            cars.Add(car5);
            cars.Add(car4);
            cars.Add(car3);
            cars.Add(car2);
            cars.Add(car1);
            Dictionary<string, int> sortedCars = new Dictionary<string, int>();
            Console.WriteLine("\n");
            for (int i = 0; i < cars.Count(); i++)
            {
                string tempMarks = "";
                if (sortedCars.Count != 0)
                {
                    foreach (var el in sortedCars)
                    {
                        tempMarks += el.Key;
                        if (el.Key == cars[i].mark)
                        {
                            sortedCars[el.Key]++;
                            break;
                        }
                    }
                    if (!tempMarks.Contains(cars[i].mark)) sortedCars.Add(cars[i].mark, 1);
                }
                else
                {
                    sortedCars.Add(cars[i].mark, 1);
                }
            }
            foreach (var el in sortedCars)
            {
                Console.WriteLine(el.Key.ToString() + ": " + sortedCars[el.Key] + " штуки\n");
            }
            Console.ReadKey();
        }
    }
}

