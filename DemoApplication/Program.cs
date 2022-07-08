// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    class Program
    {
        static void Main(String[] args) {

            //ArrayList
            ArrayList a1 = new ArrayList();

            //Stack collection
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(st.Peek());

            //Queue Collection
            Queue queue = new Queue();

            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            foreach(Object obj in queue)
            {
                Console.WriteLine(obj.ToString());
            }

            queue.Dequeue();

            foreach (Object obj in queue)
            {
                Console.WriteLine(obj.ToString());
            }

            //Hashtable

            Hashtable ht = new Hashtable();

            ht.Add("001", ".Net");
            ht.Add("002", "C#");

            //One way of accessing the hashtable
            ICollection keys = ht.Keys;

            Console.WriteLine("\nKey and Value pairs from hashtable:");

            foreach (Object obj in keys)
            {
                Console.WriteLine(ht[obj]);
            }

            Console.WriteLine(ht.ContainsKey("001"));
            Console.WriteLine(ht.ContainsValue("C#"));

            //Another way of accessing the hashtable
            Console.WriteLine("\nKey and Value pairs from hashtable:");

            foreach(DictionaryEntry elel1 in ht)
            {
                Console.WriteLine("{0} and {1}", elel1.Key, elel1.Value);
            }


            // Hello World code
            Console.WriteLine("\n=====================================");

            Console.WriteLine("\n-/- Hello, World! -/-");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

            Console.WriteLine("\nYou pressed " + consoleKeyInfo.Key.ToString());


            //Create a new object of the class Tutorial
            Tutorial tutorial = new Tutorial();

            tutorial.SetTutorial(1, ".Net");

            Console.WriteLine("\nTutorial Name: " + tutorial.GetTutorialName());

            Console.WriteLine("Tutorial ID: " + tutorial.GetTutorialID());

            //Polymorphism, we just pass one parameter
            tutorial.SetTutorial("Second .Net");

            Console.WriteLine("\nSecond Tutorial Name: " + tutorial.GetTutorialName());

            Console.ReadLine();


            //Create an object of child class ChildTutorial

            ChildTutorial childTutorial = new ChildTutorial();

            childTutorial.RenameTutorial(".Net Core");

            Console.WriteLine("New Tutorial name: " + childTutorial.GetTutorialName());
            //Console.WriteLine("New Tutorial name: " + tutorial.GetTutorialName());

            Console.ReadKey();

            //Creating objects of Car and Bicicle class
            Car car = new Car();
            Bicicle bicicle = new Bicicle();

            car.Go();

            //Because Vehicle is abstract, you cannot create an instance of that class. This is helpful for security reasons
            //Vehicle vehicle = new Vehicle();
        }

        //Creating an abstract class. Vehicle is considered incompleted, e.g. it has no wheels. Imagine a video game where the avartar is riding an invisible vehicle
       abstract class Vehicle
        {
            public int speed = 0;

            public void Go()
            {
                Console.WriteLine("This vehicle is moving");
            }
        }

        class Car : Vehicle
        {
            public int wheels = 4;
            int maxSpeed = 500;
        }

        class Bicicle : Vehicle
        {
            public int wheels = 2;
            int maxSpeed = 50;
        }
    }
}



 

