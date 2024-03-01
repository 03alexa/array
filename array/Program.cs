using System;

class Program
{
    static void Main()
    {
        // Crear un arreglo con los elementos dados
        int[] array = { 8, 43, 17, 6, 40, 16, 18, 97, 11, 7 };

        Console.WriteLine("Array original:");
        PrintArray(array);
        // Aplicar el algoritmo de ordenación Shell
        ShellSort(array);

        Console.WriteLine("\nArray ordenado con Shell Sort:");
        PrintArray(array);
    }

    static void ShellSort(int[] arr)
    {
        int n = arr.Length;
        int intervalo = n / 2;

        while (intervalo > 0)
        {
            for (int i = intervalo; i < n; i++)
            {
                int temp = arr[i];
                int j = i;

                // Realizamos intercambios dentro del subarreglo
                while (j >= intervalo && arr[j - intervalo] > temp)
                {
                    arr[j] = arr[j - intervalo];
                    j -= intervalo;
                }

                arr[j] = temp;
            }

            intervalo /= 2;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}



