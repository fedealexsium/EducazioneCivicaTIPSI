using System;
using Xunit;

public static class Test
{
    public static void Main(string[] args)
    {
        //es1
        string expected = "msky";
        string returned = Applicazione.Es1("ciao", 10);
        Assert.Equal(expected, returned);

        //es2
        expected = "ciao";
        returned = Applicazione.Es2("msky", 10);
        Assert.Equal(expected, returned);
<<<<<<< HEAD
        
        //es3
        int Iexpected = 250;
=======

        //es3
        int Iexpected = 280;
>>>>>>> dev
        int Ireturned = Applicazione.Es3("ciao", 10);
        Assert.Equal(Iexpected, Ireturned);
    }
}