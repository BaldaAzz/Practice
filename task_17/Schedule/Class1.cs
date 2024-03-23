using System;
using System.Collections.Generic;

namespace ScheduleLib;

public class Schedule
{
    private List<Event> eventsList = new();

    public string Title {get; set;}
    public DateTime StartDate {get; private set;}
    public DateTime EndDate{get; private set;}

    // Add constructor for Preferences
    public Schedule(string title, DateTime startDate, DateTime endDate)
    {
        this.Title = title;
        this.StartDate = startDate;
        this.EndDate = endDate;
    }

    public void AddEvent(Event inputEvent)
    {
        eventsList.Add(inputEvent);
    }

    public void RemoveEvent(string title)
    {
        foreach (Event currentEvent in eventsList)
        {
            if(currentEvent.Title == title)
            {
                eventsList.Remove(eventsList[eventsList.IndexOf(currentEvent)]);
                break;
            }
        }
    }

    public Event[] GetEvents() => eventsList.ToArray();
}

public class Event
{
    public string Title {get;}
    public DateTime DateAndTimeEvent {get;}
    public string Location {get;}
    public string Description {get; set;}

    public Event(string title, DateTime dateAndTimeEvent, string location)
    {
        this.Title =  title;
        this.DateAndTimeEvent = dateAndTimeEvent;
        this.Location = location;
    }

    public void AddDescription(string description)
    {
        this.Description = description;
    }
}
