using System;
using System.Collections.Generic;// need this to use lists


class Program
{
    static void Main()
    {
        //Assigment

        string[] names = { "Jonn", "Lydia", "Emma", "Elijah", "	Ava", "James", };
        int[] numbers = { 9, 8, 7, 6, 5, 4 };

        Console.WriteLine("Select the number 0-5");
        int index = Convert.ToInt32(Console.ReadLine());

        if (index == 0 || index == 1 || index == 2 || index == 3 || index == 4 || index == 5)
        {

            Console.WriteLine("The name with index: " + index + " is: " + "\"" + names[index] + "\"");
            Console.WriteLine("The number with index: " + index + " is " + "\"" + numbers[index] + "\"");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("The number has to be whole number 0-5");
            Console.ReadLine();
        }

        List<string> actorsList = new List<string>();
        actorsList.Add("Robin Williams");
        actorsList.Add("Betty White");
        actorsList.Add("Tom Hanks");
        actorsList.Add("Morgan Freeman");
        actorsList.Add("Lucille Ball");
        actorsList.Add("Harrison Ford");
        actorsList.Add("Sandra Bullock");
        actorsList.Add("Sean Connery");
        actorsList.Add("Michael J. Fox");
        actorsList.Add("Dwayne \"The Rock\" Johnson");

        Console.WriteLine("Write number 0-9 to select and actor!");
        int actorIndex = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The actor with index: " + actorIndex + " is: " + "\"" + actorsList[actorIndex] + "\"");
        Console.ReadLine();



        ////LISTS

        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Add(15);
        //Console.WriteLine(intList[2]);
        //Console.ReadLine();

        //List<string> stringList = new List<string>();
        //stringList.Add("one");
        //stringList.Add("two");
        //stringList.Add("three");
        //Console.WriteLine(stringList[2]);
        //Console.ReadLine();





        ////ARRAYS

        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //Console.WriteLine(numArray[3]);
        //Console.ReadLine();

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };
        //Console.WriteLine(numArray1[4]);
        //Console.ReadLine();

        //int[] numArray2 = { 5, 2, 10, 200, 5000 };
        //numArray2[2] = 7;
        //Console.WriteLine(numArray2[2]);
        //Console.ReadLine();

    }
}
