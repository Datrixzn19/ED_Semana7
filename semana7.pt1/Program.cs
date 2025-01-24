using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // esta es la expresion que vamos a evaluar
        string expresion = "{7+(8*5)-[(9-7)+(4+1)]}";

        // Nos ayudamos de la función VerificarBalance 
        bool balanceada = VerificarBalance(expresion);

      
        if (balanceada)
        {
            Console.WriteLine("La expresion si esta balanceada :)");
        }
        else
        {
            Console.WriteLine("La expresion no esta balanceada :(");
        }
    }


    
    static bool VerificarBalance(string expresion)
    {
        // lleva el seguimiento de los caracteres de apertura
        Stack<char> pila = new Stack<char>();


        foreach (char caracter in expresion)
        {
            // agregamos un caracter de apertura a la pila
            if (caracter == '(' || caracter == '[' || caracter == '{')
            {
                pila.Push(caracter);
            }
            // Si encontramos un carácter de cierre, hacemos las validaciones
            else if (caracter == ')' || caracter == ']' || caracter == '}')
            {
                //si hay un cierre sin su apertura la pila estara vacia 
                if (pila.Count == 0)
                {
                    return false;
                }

              
                char tope = pila.Pop();

                // Verificamos si el carácter de apertura coincide con el cierre
                if (!Coinciden(tope, caracter))
                {
                    return false;
                }
            }
        }


        return pila.Count == 0;
    }

    // Función para verificar si un carácter de apertura y uno de cierre coinciden
    static bool Coinciden(char apertura, char cierre)
    {
        
        // Devolvemos true si es valido 

    if (apertura == '(' && cierre == ')')
    {
        return true;
    }
    else if (apertura == '[' && cierre == ']')
    {
        return true;
    }
    else if (apertura == '{' && cierre == '}')
    {
        return true;
    }
    else
    {
        return false;
    }


    }
}
