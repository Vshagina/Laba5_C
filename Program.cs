using System;


class Animal
{
    public string food;
    public string location;

    public virtual void MakeNoise()
    {
        Console.WriteLine("Животное издает звук");
    }

    public void Eat()
    {
        Console.WriteLine("Животное ест " + food);
    }

    public void Sleep()
    {
        Console.WriteLine("Животное спит");
    }
}
class Dog : Animal
{
    public string breed;

    public override void MakeNoise()
    {
        Console.WriteLine("Собака лает");
    }

    public new void Eat()
    {
        Console.WriteLine("Собака ест " + food);
    }
}


class Cat : Animal
{
    public int livesLeft;

    public override void MakeNoise()
    {
        Console.WriteLine("Кошка мяучит");
    }

    public new void Eat()
    {
        Console.WriteLine("Кошка ест " + food);
    }
}

// Класс Horse, расширяющий Animal
class Horse : Animal
{
    public string color;

    public override void MakeNoise()
    {
        Console.WriteLine("Лошадь ржет");
    }

    public new void Eat()
    {
        Console.WriteLine("Лошадь ест " + food);
    }
}

// Класс Ветеринар
class Veterinarian
{
    public void TreatAnimal(Animal animal)
    {
        Console.WriteLine("Еда: " + animal.food);
        Console.WriteLine("Местоположение: " + animal.location);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.food = "кость";
        dog.location = "дом";
        dog.breed = "лабрадор";

        Cat cat = new Cat();
        cat.food = "рыба";
        cat.location = "двор";
        cat.livesLeft = 7;

        Horse horse = new Horse();
        horse.food = "сено";
        horse.location = "стойло";
        horse.color = "рыжий";

        Veterinarian vet = new Veterinarian();

        vet.TreatAnimal(dog);
        vet.TreatAnimal(cat);
        vet.TreatAnimal(horse);

        dog.MakeNoise();
        cat.MakeNoise();
        horse.MakeNoise();

        dog.Eat();
        cat.Eat();
        horse.Eat();
    }
}
