using System;
class greek
{
    public static void Main()
    {
        string str = "GeeksForGeeks";
<<<<<<< HEAD

        Console.WriteLine("I'm testing this shit");
        Console.WriteLine("Sao ko commit dc nhi");
=======
        char[] dest = new char[15];
        str.CopyTo(5, dest, 0, 3);
        Console.WriteLine(dest);
        Console.WriteLine("1");
        Console.WriteLine("133333");

>>>>>>> 475d4d1bd018446a0b38af5acfb7bc8da1eab17e
    }
}