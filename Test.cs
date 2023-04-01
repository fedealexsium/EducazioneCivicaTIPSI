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
        expected = "iao";
        returned = Applicazione.Es2("msky", 10);
        Assert.Equal(expected, returned);
    }
}