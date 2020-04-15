using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5
{
    public class GreetingsService
    {
        private delegate void GetGreeting();

        private static Dictionary<int, GetGreeting> _dictionary= new Dictionary<int, GetGreeting>() {
            {4, SayGoodNight},
            {10, SayGoodMorning},
            {17, SayGoodDay},
            {20, SayGoodEvening},
            {24, SayGoodNight}
        };
        
        public static void SayGreetings() {
            GetGreeting getGreeting = _dictionary.First(item => DateTime.Now.Hour <= item.Key).Value;
            getGreeting();
        }
        private static void SayGoodMorning() {
            Console.WriteLine("Good Morning!");
        }
        private static void SayGoodDay() {
            Console.WriteLine("Good Day!");
        }
        private static void SayGoodEvening() {
            Console.WriteLine("Good Evening!");
        }
        private static void SayGoodNight() {
            Console.WriteLine("Good Night!");
        }

    }
}