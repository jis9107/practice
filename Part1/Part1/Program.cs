using System;


namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름 :");
            string name = Console.ReadLine();
            Console.Write("나이 :");
            int age = int.Parse(Console.ReadLine());
            Console.Write("키 :");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("안녕하세요" + name + "님");
            Console.WriteLine("나이는 [age], 키는 {height}cm 이군요");
            Console.WriteLine(name);
            Console.WriteLine(age);

        }
    }
}
