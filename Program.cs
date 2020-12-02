using System;
using System.Collections.Generic;

namespace HungryNinjas
{
    class Program
    {
        static void Main(string[] args)
        {
        Buffet awesomeBuffet = new Buffet();
        Ninja ray = new Ninja();
        while (ray.IsFull == false)
        {
            ray.Eat(awesomeBuffet.Serve());
        }
        System.Console.WriteLine($"Caution: calorie intake is {ray.CalorieAmount}. The ninja is full and cannot eat anymore!");
        }
    }

    public class Food
    {
        public string Name;
        public int Calories; 
        public bool IsSpicy; 
        public bool IsSweet;

        public Food (string name, int calories, bool spicy, bool sweet)
        {
        Name = name; 
        Calories = calories; 
        IsSpicy = spicy; 
        IsSweet = sweet; 
        }
    }
    public class Buffet
    {
        public List<Food> Menu; 
        public Buffet()
        {
        Menu = new List<Food>()
        {
            new Food ("Mac n Cheese", 1000, false, false), 
            new Food ("Fried rice", 800, false, false), 
            new Food ("Pizza", 950, false, false), 
            new Food ("Chicken noodle soup", 450, false, false), 
            new Food ("Bibimbap", 850, true, false), 
            new Food ("Lasagna", 1400, false, false), 
            new Food ("Spaghetti", 1200, false, false), 
        };
        }
        Random rand = new Random();
        public Food Serve()
        {
        return Menu[rand.Next(Menu.Count)];
        }
    }

    public class Ninja
    {
        private int calorieIntake;
        public int CalorieAmount 
        {
        get 
        {
            return calorieIntake;
        }
        }
        public List<Food> FoodHistory;
        public Ninja() 
        {
        calorieIntake = 0; 
        FoodHistory = new List<Food>() { };
        }
        public bool IsFull
        {
        get 
        {
            bool full = false; 
            if (calorieIntake > 1200)
            {
            full = true;
            }
            return full;
        }
        }
        public void Eat (Food item)
        {
        calorieIntake += item.Calories;
        FoodHistory.Add(item);
        System.Console.WriteLine($"Food name: {item.Name}, Spicy: {item.IsSpicy}, Sweet: {item.IsSweet}");
        }
    }
}