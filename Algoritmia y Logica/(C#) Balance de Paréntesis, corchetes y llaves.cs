using System;
using System.Collections.Generic;

class Program
{
    static void isBalanced(string text)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in text)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                pila.Push(c);   //Agrega a la pila
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (pila.Count == 0)
                {
                    Console.WriteLine($"{text} - No balanceado");
                    return;
                }

                char ultimo = pila.Pop(); //elimina y trae ultimo elemento 

                if ((c == ')' && ultimo != '(') ||
                    (c == ']' && ultimo != '[') ||
                    (c == '}' && ultimo != '{'))
                {
                    Console.WriteLine($"{text} - No balanceado");
                    return;
                }
            }
        }

        Console.WriteLine($"{text} - {(pila.Count == 0 ? "Balanceado" : "No balanceado")}");
    }

    static void Main()
    {
        isBalanced("{[a + b] * (c + d)}");
        isBalanced("{[(])}");
        isBalanced("(3 + 2) * [5 - (7 / 2)]");
        isBalanced("{[()()]}");
        isBalanced("([)]");
        isBalanced("{[(");
        isBalanced("(([]){})"); 
        isBalanced("(([]){}");  
    }
}