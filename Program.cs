using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        /* PROBLEM 1 - (A)
        Create an Object with a "hello" method that writes "Hello <name> in the console" */
        var obj = new MyObject();
        obj.Hello("World");


        /* PROBLEM 2
        Write a funtion that logs the 5 cities that occur the most in the array below in
        order from the most number of occurrences to least. */

        var citiesList = new List<string>
        {
            "nasville", "nasville", "los angeles", "nasville", "Madrid", "memphis",
            "barcelona", "los angeles", "sevilla", "Madrid", "canary islands",
            "barcelona", "Madrid", "Madrid", "nasville", "barcelona", "london",
            "berlin", "Madrid", "nasville", "london", "Madrid", "Madrid"
        };

        var topCities = CityUtils.GetTopCities(citiesList, 5);
        Console.WriteLine("Top 5 cities:");
        foreach (var city in topCities)
        {
            Console.WriteLine($"{city.Key}: {city.Value}");
        }
    }
}