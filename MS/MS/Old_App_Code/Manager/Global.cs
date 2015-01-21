using System;
using System.Data;
using System.Collections;

public enum AdStatus
{ 
    Posted = 0,
    Accepted,
    Rejected
}



public class Global
{
    private static Random rnd = new Random();
    public static string NextActivationCode()
    {
        try
        {
            return rnd.Next(111111, 999999).ToString();
        }
        catch (Exception)
        {
            
            throw;
        }
    }
}