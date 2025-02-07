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
        //es3
        int Iexpected = 250;
        int Ireturned = Applicazione.Es3("ciao", 10);
        Assert.Equal(Iexpected, Ireturned);

        //es4
        double Dexpected = 41;
        double Dreturned = Applicazione.Es4("ciao", 10);
        Assert.Equal(Dexpected, Dreturned);

        //es5
        Dexpected = 280;
        Dreturned = Applicazione.Es5("ciao", 10);
        Assert.Equal(Dexpected, Dreturned);

        //Es6
        Iexpected = 1;
        Ireturned = Applicazione.Es6();
        Assert.Equal(Iexpected, Ireturned);

        //Es7
        Dexpected = 405;
        Dreturned = Applicazione.Es7("ciao");
        Assert.Equal(Dexpected, Dreturned);
    }
}