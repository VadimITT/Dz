﻿int[] GetArray(int length)
{
    t[] GetArray(int length)
    {
        int[] array = new int[length];

        Random r = new Random();
        for (int i = 0; i < length; i++)
        {
            array[i] = r.Next(0, 9);
        }

        return array;
    }

    string GetArrayAsString(int[] array)
    {
        string result = string.Empty;

        for (int i = 0; i < array.Length; i++)
        {
            result += $"{array[i]}, ";
        }

        return result;
    }

    Console.WriteLine(GetArrayAsString(GetArray(int.Parse(Console.ReadLine()))));