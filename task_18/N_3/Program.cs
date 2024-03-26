using System;
using System.Collections.Generic;
using System.Collections;

class Animal
{
    public string Name { get; set; }
    public string Species { get; set; }

    public Animal(string name, string species)
    {
        Name = name;
        Species = species;
    }

    public virtual void PrintAnimal()
    {
        Console.WriteLine($"Животное {Name}, вид: {Species}");
    }
}

class InfoObj
{
    public static void Info<T>(T obj) where T : Animal
    {
        obj.PrintAnimal();
    }
}

class AnimalCollection : IEnumerable
{
    private List<Animal> animalList;

    public AnimalCollection()
    {
        animalList = new List<Animal>();
    }

    public AnimalCollection(List<Animal> animals)
    {
        animalList = animals;
    }

    public void AddAnimal(Animal animal)
    {
        animalList.Add(animal);
    }

    public AnimalCollection Clone()
    {
        return new AnimalCollection(animalList);
    }

    public void RemoveAt(int i)
    {
        animalList.RemoveAt(i);
    }

    public void Clear()
    {
        animalList.Clear();
    }

    // Позволяет использовать данный класс в цикле foreach
    public IEnumerator GetEnumerator()
    {
        return animalList.GetEnumerator();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("_____Пример_____");

        Animal lion = new Animal("Лев", "Крупное Хищное Животное");
        InfoObj.Info<Animal>(lion);

        Console.WriteLine("_________________");

        AnimalCollection animalList = new AnimalCollection();
        Dictionary<int, string> Zoo = new Dictionary<int, string>(3);

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Введите имя животного:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите вид животного:");
            string species = Console.ReadLine();

            animalList.AddAnimal(new Animal(name, species));
            Zoo[i + 1] = name;
        }

        Console.WriteLine("============");

        foreach (KeyValuePair<int, string> keyValue in Zoo)
        {
            Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
        }

        Console.WriteLine("============");

        foreach (Animal animal in animalList)
        {
            animal.PrintAnimal();
        }

        animalList.RemoveAt(1);

        Console.WriteLine("============");

        AnimalCollection clonedZoo = (AnimalCollection)animalList.Clone();

        foreach (Animal animal in clonedZoo)
        {
            animal.PrintAnimal();
        }
    }
}
