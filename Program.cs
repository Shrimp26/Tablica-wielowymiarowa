using System;

//Napisz program, który w zadeklarowanej tablicy dwuwymiarowej 10 × 10 o nazwie macierz umieszcza na
//przekątnej liczby z przedziału od 0 do 9, a poza przekątną 0.
//Dodatkowo program powinien obliczać sumę wyróżnionych w tablicy elementów, tzn. elementów znajdujących się na jej przekątnej.

class TablicaWielowymiarowa
{
    static void Main(string[] args)
    {
        int[,] macierz = new int[10, 10];

        Random rand = new Random();

        for(int i = 0; i < 10;  i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (i == j)
                    macierz[i, j] = rand.Next(10);
                else
                    macierz[i, j] = 0;
            }
        }

        Console.WriteLine("Macierz: ");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(macierz[i, j] + " ");
            }

            Console.WriteLine();
        }

        int suma = 0;
        for (int i = 0; i < 10; i++)
        {
            suma += macierz[i, i];
        }

        Console.WriteLine($"Suma elementów na przekątnej wynosi: {suma}.");
    }

}
