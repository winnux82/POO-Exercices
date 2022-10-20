/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");


        var liste = new List<int>();
        liste.Add(a);
        liste.Add(b);
        liste.Add(c);

        liste.Add(d);

        int reponse = liste.Max() - liste.Min();
        Console.WriteLine(reponse);

    }
}