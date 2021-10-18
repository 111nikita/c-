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
        public void Action(int num, string str)
        {
            Console.WriteLine($" {num}  {str}");
        }
        public Parametr() { num = 1; str = "Кто прочитал, тот сдохнет"; }

        public Parametr(string voskres) { num = 2; str = voskres; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Parametr F = new();
            Parametr A = new("Кто прочитал, тот воскресе");
            F.Action();
            A.Action();
            F.Action(4, "Четыре в Японии число смерти");

        }
    }
}