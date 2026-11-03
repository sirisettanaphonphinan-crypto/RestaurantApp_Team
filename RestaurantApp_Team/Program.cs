using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp_Team
{
    //เอาไว้ใน Namespace
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
            Console.WriteLine("Not completed");
        }

        // คน B รับผิดชอบ
        static void ShowGoodRating()
        {
            Console.WriteLine("Not completed");
        }

        // คน C รับผิดชอบ
        static void ShowSummary()
        {
            var sortedList = restaurants.OrderByDescending(x => x.Rating).ToList();
            Console.WriteLine("=== รายชื่อร้านอาหารทั้งหมด (เรียงตามคะแนนสูงสุด-ต่ำสุด) ===");
            int a = 1;
            foreach(Restaurant item in restaurants)
            {
                Console.WriteLine($"{a}. ชื่อร้านที่มีคะแนนสูงสุด: {item.Name} Rate: {item.Rating} \n ชื่อร้านที่มีคะแนนต่ำสุด: {item.Name} Rate: {item.Rating}");
                a++;
            }
        }
    }

}
