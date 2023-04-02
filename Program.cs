using System;

public static class Applicazione
{
    private static string alfabeto = "abcdefghijklmnopqrstuvwxyz";
    private static int contatore = 0;
    public static string Es1(string s, int n)
    {
        int index = 0;
        string stringaFinale = "";
        foreach (var item in s)
        {
            s = s.ToLower();
            index = 0;
            while (item != alfabeto[index])
            {
                index++;
            }
            index += n;
            if (index > 25)
            {
                index -= 25;
            }
            stringaFinale += alfabeto[index];
        }
        return stringaFinale;
    }

    public static string Es2(string s, int n)
    {
        int index = 0;
        string stringaFinale = "";
        foreach (var item in s)
        {
            s = s.ToLower();
            index = 0;
            while (item != alfabeto[index])
            {
                index++;
            }
            index -= n;
            if (index < 0)
            {
                index += 25;
            }
            stringaFinale += alfabeto[index];
        }
        return stringaFinale;
    }

    public static int Es3(string s, int n)
    {
        int index = 0;
        int totale = 0;
        foreach (var item in s)
        {
            s = s.ToLower();
            index = 0;
            while (item != alfabeto[index])
            {
                index++;
            }
            totale += index + 1;
        }
        return totale * n;
    }

    public static double Es4(string s, int n)
    {
        int index = 0;
        double totale = 1;
        foreach (var item in s)
        {
            s = s.ToLower();
            index = 0;
            while (item != alfabeto[index])
            {
                index++;
            }
            totale *= (index + 1);
        }
        return Math.Ceiling(totale / n);
    }

    public static double Es5(string s, int n)
    {
        contatore++;
        if (n % 2 == 0)
        {
            return Es3(s, n);
        }
        else
            return Es4(s, n);
    }

    public static int Es6()
    {
        return contatore;
    }

    public static double Es7(string s)
    {
        return Es5(s, contatore);
    }
}