using System;

namespace N_3
{
    class MyInfo
    {
        public delegate void MyInfoHandler(string message);
        public event MyInfoHandler? Notify;

        private string name;

        public MyInfo(string name)
        {
            this.name = name;
            this.Notify += DisplayMessage;
        }
        private void DisplayMessage(string message) => Console.WriteLine(message);

        public void ChangeName(string otherName)
        {
            this.name = otherName;
            Notify?.Invoke($"Произошло изменение имени на {otherName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyInfo person = new("Дмитрий");
            person.ChangeName("Mike");
            person.ChangeName("Adidas");
            person.ChangeName("Олег");
        }
    }
}