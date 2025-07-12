using System;
using Microsoft.SqlServer.Server;

public class UdfFunctions
{
    [SqlFunction]
    public static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    [SqlFunction]
    public static DateTime GetCurrentDate()
    {
        return DateTime.Now;
    }

    [SqlFunction]
    public static int MultiplyNumbers(int a, int b)
    {
        return a * b;
    }
}