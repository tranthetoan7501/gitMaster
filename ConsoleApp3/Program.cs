using System;
class greek
{
    public static void Main()
    {
        string str = "GeeksForGeeks";
        char[] dest = new char[15];
        str.CopyTo(5, dest, 0, 3);
        Console.WriteLine(dest);
        Console.WriteLine("1");
        Console.WriteLine("8,8991");
    }
}
