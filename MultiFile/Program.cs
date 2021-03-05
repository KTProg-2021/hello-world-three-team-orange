﻿using System;

namespace MultiFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate start = new Coordinate(12, 23,8);
            Item trinket = new Item("box","green");
            Person patient = new Person("Joe Smith", "5'11\"", "175 lbs", "joeSmith8809@gmail.com");
            Automobile car = new Automobile("Toyota", "RAV4", "XLE");
            City location = new City("Framingham", "Massachusetts", 72308);
            Appliance kitchenItem = new Appliance("Refrigerator", 799, "Black");

            Console.WriteLine("Hello World!");
            start.display();
            trinket.display();
            patient.display();
            car.display();
            location.display();
            kitchenItem.display();
        }
    }
}
