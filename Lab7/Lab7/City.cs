using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace Lab7
{
    class City:IComparable,IEnumerable
    {
        protected string city;
        protected double territory;
        protected double population;
        public string City_
        {
            get { return city; }
        }

        public double Territory
        {
            get { return territory; }
        }

        public double Population
        {
            get { return population; }
        }
        public City(string city, double territory, double population)
        {
            this.city = city;
            this.territory = territory;
            this.population = population;
        }
        protected int n;
        protected City[] Cities;

        public void ComapreTo()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть кількість міст:");
            n = Convert.ToInt32(Console.ReadLine());
            Cities = new City[n];//масив міст
            for (int i = 0; i < n; i++)
            {
                Console.Write("Назва міста: ");
                string gorod = Console.ReadLine();
                Console.Write("Територія: ");
                double teretoria = Convert.ToDouble(Console.ReadLine());
                Console.Write("Населення: ");
                double naselenie = Convert.ToDouble(Console.ReadLine());
                Cities[i] = new City(gorod,teretoria,naselenie);//вносимо в масив нові дані
            }
        }

        public void PrintByDecrease()
        {
            Console.WriteLine("\tПерегляд міст\t");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Назва міста: {0}; Територія: {1}; Населення: {2}.", Cities[i].City_, Cities[i].Territory, Cities[i].Population);//виводимо інформацію
            }
        }

        static void Main(string[] args)
        {
            City c = new City("0",0,0);
            c.ComapreTo();
            c.PrintByDecrease();
        }
    }
}
