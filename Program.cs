using System;

namespace NestedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nested Classes!");
            Animals animal = new Animals();

            //Cannot access Cat or Dog
            animal.animalCountry = "USA";

            //Declare Dogs within Animals
            Animals.Dogs dog = new Animals.Dogs();
            dog.dogBreed = "German Sheperd";

            //Declare Cats within Animals
            Animals.Cats cat = new Animals.Cats();
            cat.catName = "Mr Piffles";
        }
    }

    class Animals
    {
        public string animalName;
        public string animalCountry;

        public class Dogs
        {
            public string dogBreed;
            public string dogNickname
        }

        public class Cats
        {
            public string catName;
        }
        
    }
}
