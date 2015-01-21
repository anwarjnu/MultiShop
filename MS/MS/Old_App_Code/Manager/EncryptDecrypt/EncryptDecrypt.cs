using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Summary description for Common
/// </summary>
public static class EncryptDecrypt
{
    public static int key = 129;

    
    public static string EncryptString(string str)
    {
        Byte[] b;

        b = ASCIIEncoding.ASCII.GetBytes(str);
        return Convert.ToBase64String(b);
    }

    // This method is used to decrypt the string
    public static string DecryptString(string str)
    {
        Byte[] b;

        b = Convert.FromBase64String(str);
        return ASCIIEncoding.ASCII.GetString(b);
    }
   
}
