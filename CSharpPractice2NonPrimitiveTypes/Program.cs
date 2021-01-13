using System;

namespace CSharpPractice2NonPrimitiveTypes
{
    public enum ShippingMethod
    {
        RegMail = 1,
        AirMail = 2,
        ExpMail = 3
    }

    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Create arryas*/
            var numbers = new int[3];//int[] is reped by var
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);//Default int val 0
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);//Default val set to false for bools
            Console.WriteLine(flags[2]);

            var names = new string[] {"Ranger", "Freyja", "Ember", "Coal" };//if you know the values use this notation to set them.
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            /*Create Strings*/
            var firstName = "Asia";
            var lastName = "Gault";
            Console.WriteLine(firstName+ " " +lastName);
            var myFullName = string.Format("My Name Is: {0} {1}", firstName, lastName);

            /*Using join to separate stings by ","*/
            var petNames = new string[4] { "Ranger", "Freyja", "Ember", "Coal" };
            var listPets = string.Join(",", petNames);
            Console.WriteLine(listPets);
            //Virbatim Strings use @ so you dont need /n-new line or // in string.

            //Enums defined under name space
            var method = ShippingMethod.ExpMail;//CALLS expMail under Shipping enum at top
            Console.WriteLine((int)method);// Cast to int

            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId);// using casting to get the associated name of the respective ID
            
            //Parse string to enum
            var methodName = "ExpMail";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

            //related to Age
            var number = 1;
            Increment(number);//diff value than other number below. diff places in memeory bec value type

            var person = new Person() {Age = 20};
            MakeOld(person);// because new spot in memory can change value 
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }

    }
}
