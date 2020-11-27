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
        int intentos = 0;

        Console.Write("Cadena: ");
        adivinar = Console.ReadLine();
        //Como en un string no se puede sustituir letra a letra he creado un array
        //que cada valor será cada letra de la palabra
        char[] ahorcado = new char[adivinar.Length];
        
        //Lleno el array con tantos guiones como longitud de palabra vayamos a adivinar
        for (int i = 0; i < adivinar.Length; i++)
        {
            ahorcado[i] = '_';
        }
        
        //Va a seguir pidiendo letras y mostrando el ahorcado hasta que falle 6 veces (o acierte)
        do
        {
            Console.WriteLine();
            Console.Write("Letra: ");
            letra = Convert.ToChar(Console.ReadLine());

            if (adivinar.Contains(letra))
            {
                //1º for: va sustituyendo "_" por la letra que meta el usuario si coincide
                for (int i = 0; i < adivinar.Length; i++)
                {
                    if (adivinar.IndexOf(letra, i) >= 0)
                    {
                        ahorcado[adivinar.IndexOf(letra, i)] = letra;
                    }

                }
                //La variable palabra me va a servir para comparar el resultado final del array
                string palabra = "";

                //2º for: El array contiene "elementos sueltos", por lo que vamos a
                //"convertirlo" en una palabra (variable string) y así poder compararla luego
                for (int i = 0; i < adivinar.Length; i++)
                {
                    palabra = palabra + Convert.ToString(ahorcado[i]);
                }

                //Si la palabra ya coincide con la que ibamos a adivinar sale del bucle
                if (palabra == adivinar)
                {
                    Console.WriteLine("¡¡¡ENHORABUENA!!!");
                    break;
                }
            }

            //Si falla le mostrará el dibujo correspondiente en funcion de los fallos cometidos
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

        //Si comete mas de 6 fallos termina el juego
        Console.WriteLine();
        Console.WriteLine("R.I.P. La palabra era {0}", adivinar);
        
    }
}