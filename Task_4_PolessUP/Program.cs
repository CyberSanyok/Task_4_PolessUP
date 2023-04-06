using System.Security;

internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] ints = new int[10] {10,2,3,4,8,6,7,5,9,1};
        Array.Sort(ints);
        if (ints.Length == 1) Console.WriteLine(ints[0]);
        if(ints.Length==2) Console.WriteLine(ints[1]);
        Console.WriteLine(string.Join(", ",ints));
        Console.WriteLine(ints[ints.Length-3]);
    }
}