using System;
using Xunit;

public static class Test
{
    public static void Main(string[] args)
    {
        string expected = "msky";
        string returned = Applicazione.Es1("ciao", 10);
        Assert.Equal(expected, returned);
    }
}