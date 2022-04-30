using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace PetApp
{

    public interface ICat
    {
        void Eat();

        void Play();

        void Scratch();

        void Purr();


    }

    public class Cat : Pet, ICat
    {

        public Cat()
        {

        }
        public override void Eat()
        {
            Console.WriteLine(this.Name + " is hungry. Meow!");

        }
        public override void Play()
        {
            Console.WriteLine(this.Name + " is bored. Throw them a ball!");

        }
        public void Purr()
        {
            Console.WriteLine(this.Name + " is happy. Purrrrrrrr....");

        }
        public void Scratch()
        {
            Console.WriteLine(this.Name + " needs a scratch. You scratch their back before they scratch yours!");
        }
        public override void GotoVet()
        {
            Console.WriteLine(this.Name + " is a little sick. Kitty needs some medicines...");
        }
    }
    public abstract class Pet
    {
        private string name;
        public int age;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public abstract void Eat();

        public abstract void Play();

        public abstract void GotoVet();

        public Pet()
        {

        }

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

    }

    public class Pets
    {
        List<Pet> petList = new List<Pet>();

        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }

        public int Count
        {
            get
            {
                return petList.Count;
            }
        }

        /*
        public override void Eat() { }

        public override void Play() { }

        public override void GotoVet() { }
        */

        public void Add(Pet pet)
        {
            petList.Add(pet);
        }
        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }
        public void RemoveAt(int petEl)
        {
            petList.RemoveAt(petEl);
        }
    }


    public class Dog : Pet, IDog
    {

        public string license;

        public static void EvictCat(object sender, ElapsedEventArgs e)
        {

        }

        public override void Eat()
        {
            Console.WriteLine(this.Name + " is hungry. Needs juicy bone!");

        }

        public override void Play()
        {
            Console.WriteLine(this.Name + " wants to play fetch... Throw them a ball!");
        }
        public void Bark()
        {
            Console.WriteLine(this.Name + " is barking. Woof Woof!");
        }
        public void NeedWalk()
        {
            Console.WriteLine(this.Name + " needs to walk... HURRY!");
        }
        public override void GotoVet()
        {
            Console.WriteLine(this.Name + " is a little sick... whimper...");

        }

        public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
        {
            this.license = szLicense;
        }
    }

    public interface IDog
    {
        void Eat();

        void Play();

        void Bark();

        void NeedWalk();

        void GotoVet();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(20000);
            myTimer.Elapsed += new ElapsedEventHandler(Dog.EvictCat);
            myTimer.Start();

            //1
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            //2
            Pets pets = new Pets();

            //3
            Random rand = new Random();

            //4
            for (int i = 0; i < 50; i++)
            {
                ReturnHereIfNull:
                int iNewRandom = rand.Next(1, 11);

                // 1 in 10 chance of adding an animal
                if (iNewRandom == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        string dogName;
                        int dogAge;
                        string dogLz;
                        Console.WriteLine("You bought a Dog!");
                        Console.Write("Name the Dog-> ");
                        dogName = Console.ReadLine();
                        Console.Write("What's the Dog's age? -> ");
                        dogAge = Convert.ToInt32(Console.ReadLine());
                        Console.Write("What's the Dog's license ID? -> ");
                        dogLz = Console.ReadLine();

                        dog = new Dog(dogLz, dogName, dogAge);
                        // add a dog
                        pets.Add(dog);

                    }
                    else
                    {
                        string catName;
                        int catAge;

                        Console.WriteLine("You bought a Cat!");
                        Console.Write("Name the Cat-> ");
                        catName = Console.ReadLine();
                        Console.Write("What's the Cat's age? -> ");
                        catAge = Convert.ToInt32(Console.ReadLine());

                        cat = new Cat();
                        cat.Name = catName;
                        cat.age = catAge;
                        // else add a cat
                        pets.Add(cat);
                    }
                }
                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do
                    thisPet = pets[rand.Next(0, pets.Count)];

                    if (thisPet == null)
                    {

                        goto ReturnHereIfNull;
                    }
                    else
                    {
                        if (thisPet.GetType() == typeof(Dog))
                        {
                            iDog = (IDog)thisPet;
                            int randomActivity = rand.Next(1, 6);

                            if (randomActivity == 1)
                            {
                                iDog.Bark();
                            }
                            else if (randomActivity == 2)
                            {
                                iDog.NeedWalk();
                            }
                            else if (randomActivity == 3)
                            {
                                iDog.GotoVet();
                            }
                            else if (randomActivity == 4)
                            {
                                iDog.Play();
                            }
                            else if (randomActivity == 5)
                            {
                                iDog.Eat();
                            }
                        }
                        else if (thisPet.GetType() == typeof(Cat))
                        {
                            iCat = (ICat)thisPet;
                            int randomActivity = rand.Next(1, 5);

                            if (randomActivity == 1)
                            {
                                iCat.Purr();
                            }
                            else if (randomActivity == 2)
                            {
                                iCat.Scratch();
                            }
                            else if (randomActivity == 3)
                            {
                                iCat.Eat();
                            }
                            else if (randomActivity == 4)
                            {
                                iCat.Play();
                            }

                        }

                    }
                }



            }

        }
    }
}
