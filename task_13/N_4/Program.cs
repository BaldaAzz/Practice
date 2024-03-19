using System;

/*
Ссылка на статью, где лучше объясняется про событие
Может пригодится
https://habr.com/ru/articles/213809/
*/

namespace N_4
{
    class Meteorite
    {
        public delegate void MethodContainer();
        public event MethodContainer whenFall;

        public void FallToEarth()
        {   
            whenFall();
            Console.WriteLine("Метиорит упал на землю");
        }
    }

    class God
    {
        public void Say() => Console.WriteLine("Бог сказал: Ахахах");
    }

    class Dinosaur
    {
        public void Say() => Console.WriteLine("Динозавр прокричал: О нет! Мы все умрём!!!");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Meteorite meteorite = new();
            God god = new();
            Dinosaur Anton = new();

            meteorite.whenFall += god.Say;
            meteorite.whenFall += Anton.Say;

            meteorite.FallToEarth();
        }
    }
}