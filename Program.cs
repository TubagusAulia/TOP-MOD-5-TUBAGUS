﻿using System;

class HaloGeneric
{
    public static void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }

    static void Main()
    {
        SapaUser("Tubagus");
    }
}
