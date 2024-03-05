using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool oriented = true;
        List<List<int>> adjacency_list_init = new List<List<int>>();
        List<List<int>> adjacency_list_full = new List<List<int>>();
        string proceed = "y";
        while (proceed == "y")
        {
            Console.Write("enter two starting and ending point: ");
            string input_points = Console.ReadLine();
            string[] input_points_arr = input_points.Split(",");
            List<int> input_points_list = new List<int>();
            foreach (string point in input_points_arr)
            {
                input_points_list.Add(int.Parse(point));
            }
            adjacency_list_init.Add(input_points_list);
            Console.Write("proceed entering points? [y]/[n] ");
            proceed = Console.ReadLine();
        }
        Console.WriteLine(string.Join(", ", adjacency_list_init));
        if (oriented)
        {
            for (int i = 0; i < adjacency_list_init.Count; i++)
            {
                adjacency_list_full.Add(adjacency_list_init[i]);
                adjacency_list_full.Add(new List<int>(adjacency_list_init[i].ToArray().Reverse()));
            }
            Console.WriteLine(string.Join(", ", adjacency_list_full));
        }
    }
}
