// --------------------------------------------
// Rocío Beato Martín
// 1º Curso DAW
// Modalidad Semipresencial
// Práctica nº 2
// --------------------------------------------
using System;
public class Practica2
{
    public static void Main()
    {
        string adivinar;
        char letra;

        Console.Write("Cadena: ");
        adivinar = Console.ReadLine();
        char[] ahorcado = new char[adivinar.Length];
        int intentos = 0;

        for (int i = 0; i < adivinar.Length; i++)
        {
            ahorcado[i] = '_'; sfdsdfdsfdsf
        }

        do
        {
            Console.WriteLine();
            Console.Write("Letra: ");
            letra = Convert.ToChar(Console.ReadLine());

            int encontrado = 0;

            if (adivinar.Contains(letra))
            {
                for (int i = 0; i < adivinar.Length; i++)
                {
                    if (adivinar.IndexOf(letra, i) >= 0)
                    {
                        ahorcado[adivinar.IndexOf(letra, i)] = letra;
                        encontrado++;
                    }

                    else if (i == adivinar.Length - 1 && encontrado == 0)
                    {
                        intentos++;
                    }
                }
            }

            else
            {
                if (intentos > 0)
                {
                    switch (intentos)
                    {
                        case 1:
                            {
                                Console.WriteLine("┌───┐");
                                Console.WriteLine("│   o");
                                Console.WriteLine("│");
                                Console.WriteLine("│");
                                Console.WriteLine("┴───────");
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("┌───┐");
                                Console.WriteLine("│   o");
                                Console.WriteLine("│  /");
                                Console.WriteLine("│");
                                Console.WriteLine("┴───────");
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("┌───┐");
                                Console.WriteLine("│   o");
                                Console.WriteLine("│  /|");
                                Console.WriteLine("│");
                                Console.WriteLine("┴───────");
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("┌───┐");
                                Console.WriteLine("│   o");
                                Console.WriteLine("│  /|\\");
                                Console.WriteLine("│  ");
                                Console.WriteLine("┴───────");
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("┌───┐");
                                Console.WriteLine("│   o");
                                Console.WriteLine("│  /|\\");
                                Console.WriteLine("│  /");
                                Console.WriteLine("┴───────");
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("┌───┐");
                                Console.WriteLine("│   o");
                                Console.WriteLine("│  /|\\");
                                Console.WriteLine("│  / \\");
                                Console.WriteLine("┴───────");
                                break;
                            }

                    }
                }
            }            

           

            for (int k = 0; k < ahorcado.Length; k++)
            {
                Console.Write(ahorcado[k]);
            }

        } while (intentos < 6);

        if (intentos == 6)
        {
            Console.WriteLine();
            Console.WriteLine("R.I.P. La palabra era {0}", adivinar);
        }

        else
        {
            Console.WriteLine("¡¡¡ENHORABUENA!!!");
        }
    }
}