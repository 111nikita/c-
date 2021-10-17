using System;

namespace task4
{
    public class Parametr
    {
        public int num;
        public string str;
        public void Action()
        {
            Console.WriteLine($"num = {num} str = {str}");
        }
        public Parametr() { num = 1001; str = "I like Smells like teen spirit"; }

        public Parametr(string e) { num = 1488; str = e; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Parametr F = new Parametr();
            Parametr A = new("Кто прочитал, тот воскресе");
            A.Action();
            F.Action();
        }
    }
}