using System;

public static class Applicazione
{
    private static string alfabeto = "abcdefghijklmnopqrstuvwxyz";
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
}