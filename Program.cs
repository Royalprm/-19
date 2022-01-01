using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнение_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> pcList = new List<Computer>
            {
                new Computer() {Code = "3", Name = "LowCost 3", CPU = "Intel Core i3", ClockSpeed = 3400, RAM = 16, HDD = 256, VGA = 4, Price = 700, Count = 300 },
                new Computer() {Code = "5", Name = "MidCost 2", CPU = "Intel Core i5", ClockSpeed = 3800, RAM = 16, HDD = 512, VGA = 6, Price = 900, Count = 5 },
                new Computer() {Code = "2", Name = "LowCost 2", CPU = "Intel Core i3", ClockSpeed = 3200, RAM = 8, HDD = 256, VGA = 2, Price = 600, Count = 250 },
                new Computer() {Code = "7", Name = "HighCost 1", CPU = "Intel Core i7", ClockSpeed = 4200, RAM = 32, HDD = 1024, VGA = 8, Price = 1200, Count = 15 },
                new Computer() {Code = "8", Name = "HighCost 2", CPU = "Intel Core i9", ClockSpeed = 4400, RAM = 64, HDD = 1024, VGA = 12, Price = 1500, Count = 10 },
                new Computer() {Code = "4", Name = "MidCost 1", CPU = "Intel Core i5", ClockSpeed = 3600, RAM = 16, HDD = 512, VGA = 6, Price = 800, Count = 200 },
                new Computer() {Code = "1", Name = "LowCost 1", CPU = "Intel Core i3", ClockSpeed = 3000, RAM = 8, HDD = 256, VGA = 1, Price = 500, Count = 400 },
                new Computer() {Code = "6", Name = "MidCost 3", CPU = "Intel Core i5", ClockSpeed = 4000, RAM = 32, HDD = 512, VGA = 8, Price = 1000, Count = 80 },
            };
            #region 
            
            
            Console.Write("Введите название процессора: ");
            string question = Console.ReadLine();
            var result = pcList.Where(q => q.CPU.Contains(question));
            Console.WriteLine("\nList:");
            foreach (var i in result)
            {
                i.GetInfo();
            }

            
            Console.WriteLine("\nНажмите любую кнопку");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region 
            
            
            Console.Write("Введите минимальный объем ОЗУ: ");
            int question2 = Convert.ToInt32(Console.ReadLine());
            result = pcList.Where(q => q.RAM >= question2);
            Console.WriteLine("\nList:");
            foreach (var i in result)
            {
                i.GetInfo();
            }

            
            Console.WriteLine("\nНажмите любую кнопку");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region 
            
            Console.WriteLine("Список по увеличению стоимости\n");
            result = pcList.OrderByDescending(q => q.Price);
            Console.WriteLine("List:");
            foreach (var i in result)
            {
                i.GetInfo();
            }

            
            Console.WriteLine("\nНажмите любую кнопку");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region 
            
            Console.WriteLine("Список по типу процессора\n");
            var groupByCPU = pcList.GroupBy(q => q.CPU);
            Console.WriteLine("List:");
            foreach (var i in groupByCPU)
            {
                Console.WriteLine(i.Key);
                foreach (var j in i)
                {
                    Console.Write("\t");
                    j.GetInfo();
                }
                Console.WriteLine();
            }

            
            Console.WriteLine("\nНажмите любую кнопку");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region 
                        Console.WriteLine("Самый дорогой/Самый бюджетный компьютер\n");

            // first variant
            Console.WriteLine("Max price:");
            var max = pcList.OrderBy(q => q.Price).First();
            max.GetInfo();
            Console.WriteLine("\nMin price:");
            var min = pcList.OrderBy(q => q.Price).Last();
            min.GetInfo();

            // second variant
            //var max = pcList.Where(r => r.Price == pcList.Max(q => q.Price));
            //var min = pcList.Where(r => r.Price == pcList.Min(q => q.Price));
            //Console.WriteLine("List max:");
            //foreach (var i in max)
            //{
            //    i.GetInfo();
            //}
            //Console.WriteLine("\nList min:");
            //foreach (var i in min)
            //{
            //    i.GetInfo();
            //}

            
            Console.WriteLine("\nНажмите любую кнопку");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region 
            
            Console.WriteLine("Тип компьютера в количестве больше 30 шт.\n");
            bool test = pcList.Any(q => q.Count > 30);
            if (test)
            {
                int count = pcList.Where(q => q.Count > 30).Count();
                Console.WriteLine($"\nСписок содержит {count} количество элементов больше 30");
            }
            else
            {
                Console.WriteLine($"\nСписок не содержит количество элементов больше 30");
            }

            
            Console.WriteLine("\nНажмите любую кнопку");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    
    }

    class Computer
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string CPU { get; set; }
        public int ClockSpeed { get; set; }
        public int RAM { get; set; }
        public int HDD { get; set; }
        public int VGA { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public void GetInfo()
        {
            Console.WriteLine($"{Code} / {Name} / {CPU} / {ClockSpeed} / {RAM} / {HDD} / {VGA} / {Price} / {Count}");
        }
    }
}
