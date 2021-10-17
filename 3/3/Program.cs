using System;

namespace task3
{
    public interface animals
    {
        public void Sound();
    }
    class Cow : animals
    {
        public void Sound()
        {
            Console.WriteLine("Муууу");
        }
    }
    class dog : animals
    {
        public void Sound()
        {
            Console.WriteLine("Гав гав");
        }
    }

    class Parrot : animals
    {
        public void Sound()
        {
            Console.WriteLine("Унга-бунга");
        }
    }
    class Program
    {
        static void Sounds(animals _animals)
        {
            _animals.Sound();
        }
        static void Main(string[] args)
        {
            Cow Cow = new Cow();
            dog dog = new dog();
            Parrot Parrot = new Parrot();
            Sounds(dog);
            Sounds(Cow);
            Sounds(Parrot); 
        }
    }
}