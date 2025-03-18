﻿using System;

public class Program
{
    public static void Main(string[] args)
    {
        Matematik matematik = new Matematik();
        Console.WriteLine("Toplama işlemleri:");
        Console.WriteLine("2 + 3 = " + matematik.Topla(2, 3));  
        Console.WriteLine("2 + 3 + 4 = " + matematik.Topla(2, 3, 4));  
        Console.WriteLine("2.5 + 3.5 = " + matematik.Topla(2.5, 3.5));  
        Console.WriteLine("2.5 + 3.5 + 4.5 = " + matematik.Topla(2.5, 3.5, 4.5));  

        
        Console.WriteLine("\nÇarpma işlemleri:");
        Console.WriteLine("2 * 3 = " + matematik.Carp(2, 3));  
        Console.WriteLine("2 * 3 * 4 = " + matematik.Carp(2, 3, 4));  
        Console.WriteLine("2.5 * 3.5 = " + matematik.Carp(2.5, 3.5));  
        Console.WriteLine("2.5 * 3.5 * 4.5 = " + matematik.Carp(2.5, 3.5, 4.5));  
    }
}
