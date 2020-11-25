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
        bool resuelto = false;

        for (int i = 0; i < adivinar.Length; i++)
        {
            ahorcado[i] = '_';
        }

        do
        {
            Console.WriteLine();
            Console.Write("Letra: ");
            letra = Convert.ToChar(Console.ReadLine());

            if (adivinar.Contains(letra))
            {
                for (int i = 0; i < adivinar.Length; i++)
                {
                    if (adivinar.IndexOf(letra, i) >= 0)
                    {
                        ahorcado[adivinar.IndexOf(letra, i)] = letra;
                    }
                }
            }
            else
            {
                intentos++;
            
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

            for (int i = 0; i < ahorcado.Length; i++)
            {
                Console.Write(ahorcado[i]);
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