using System;
using ScheduleLib;

namespace N_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Event[] events = {
                new("Поход в магазин", new DateTime(2024, 12, 13), "Магазин"),
                new("Поход к врачу", new DateTime(2024, 12, 12), "Больница")
            };
            
            Schedule mySchedule = new(
                "Моё расписание",
                new DateTime(2024, 1, 1),
                new DateTime(2024, 12, 31)
            );

            foreach (Event currentEvent in events)
            {
                mySchedule.AddEvent(currentEvent);
            }

            foreach (Event currentEvent in mySchedule.GetEvents())
            {
                Console.WriteLine(currentEvent.Title);
                Console.WriteLine(currentEvent.DateAndTimeEvent);
                Console.WriteLine(currentEvent.Location);
            }
        }
    }
}