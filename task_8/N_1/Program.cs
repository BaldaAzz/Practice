namespace N_1
{
    class Program
    {
        public struct TRAIN
        {
            public string destination;
            public int trainNumber;
            public DateTime departureTime;
        }

        public static void PrintTrainInfo(int trainNumber, TRAIN[] trains)
        {
            bool founded = false;

            foreach (TRAIN train in trains)
            {
                if (train.trainNumber == trainNumber)
                {
                    Console.WriteLine(train.destination);
                    Console.WriteLine(train.trainNumber);
                    Console.WriteLine(train.departureTime);

                    founded = true;
                }
            }

            if (!founded)
            {
                Console.WriteLine("Данный поезд не был найден! ");
            }
        }

        static void Main(string[] args)
        {
            TRAIN[] trains = new TRAIN[3];

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Пункт назначения");
                trains[i].destination = Console.ReadLine();

                Console.WriteLine("Номер поезда");
                trains[i].trainNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Дата отправления");
                trains[i].departureTime = Convert.ToDateTime(Console.ReadLine());
            }

            trains = trains.OrderBy(i => i.trainNumber).ToArray();

            PrintTrainInfo(Convert.ToInt32(Console.ReadLine()), trains);
        }
    }
}