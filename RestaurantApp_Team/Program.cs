using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp_Team
{
    class Restaurant
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }
        public Restaurant(string name, string type, double rating)
        {
            Name = name;
            Type = type;
            Rating = rating;
        }
    }

    internal class Program
    {
        static List<Restaurant> restaurants = new List<Restaurant>();
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("\n===== Restaurant Menu =====");
                Console.WriteLine("1. Add Restaurant");
                Console.WriteLine("2. Show Good Rating");
                Console.WriteLine("3. Show Summary");
                Console.WriteLine("0. Exit");
                Console.Write("Select Menu: ");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        AddRestaurant();
                        break;
                    case "2":
                        ShowGoodRating();
                        break;
                    case "3":
                        ShowSummary();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid Menu");
                        break;
                }
            }
        }

        // คน A รับผิดชอบ
        static void AddRestaurant()
        {
            

            Console.Write("กรอกชื่อร้าน: ");
            string name = Console.ReadLine();

            Console.Write("กรอกประเภทอาหาร: ");
            string type = Console.ReadLine();

            Console.Write("กรอกคะแนน (เช่น 4.5): ");
            
            double rating = Convert.ToDouble(Console.ReadLine());

            restaurants.Add(new Restaurant(name, type, rating));

            Console.WriteLine("เพิ่มร้านเรียบร้อยแล้ว!");
            
        }

        // คน B รับผิดชอบ
        static void ShowGoodRating()
        {
            Console.WriteLine("Not completed");
        }

        // คน C รับผิดชอบ
        static void ShowSummary()
        {
            Console.WriteLine("Not completed");
        }
    }

}
