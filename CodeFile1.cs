
using System;
class MazeRunners
{
    static string[] mazeLines = System.IO.File.ReadAllLines("test.txt"); // test file used (placed in bin/debug for replacement
    static void Main()
    {
        // this is for me to test 
        pathFinder(mazeLines[0], mazeLines.Length); // initial call
        Console.Read();
    }

    static int pathFinder(string path, int routesLeft, int lastIndex = -1, int arrNum = -1)
    {
        // base case (return for sure if this because its the last line)
        if (routesLeft == 1)
        {
            Console.WriteLine("({0},{1})", arrNum + 1, lastIndex + 1);
            Console.WriteLine("The Path has been found!");
            return 0;
        }
        if (lastIndex == -1)
        {
            // this is the first line and maze entrance 
            int ind = path.IndexOf('1');
            Console.WriteLine("(1,{0})", ind + 1);
            return pathFinder(mazeLines[1], routesLeft - 1, ind, 1);
        }
        // the following has to have an established index 
        // check for if 1 is next or if we have to look for other char on same line
        char c = mazeLines[arrNum + 1][lastIndex];
        if (c == '1')
        {
            Console.WriteLine("({0},{1})", arrNum + 1, lastIndex + 1);
            return pathFinder(mazeLines[arrNum + 1], routesLeft - 1, lastIndex, arrNum + 1);
        }
        // else if but i need to change c 
        c = path[lastIndex - 1];
        if (c == '1' && mazeLines[arrNum + 1][lastIndex - 1] == '1')
        {
            Console.WriteLine("({0},{1})", arrNum + 1, lastIndex + 1);
            return pathFinder(path, routesLeft, lastIndex - 1, arrNum);
        }
        else
        {
            Console.WriteLine("({0},{1})", arrNum + 1, lastIndex + 1);
            return pathFinder(path, routesLeft, lastIndex + 1, arrNum);
        }
    }
}
