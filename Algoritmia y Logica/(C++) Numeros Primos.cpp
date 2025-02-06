/*
 * Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 */

 #include <iostream>
using namespace std;

bool isPrimo(int number) {
    if(number < 2){return false;}

    for(int i = 2; i < number; i++)
    {
     if(number % i == 0){ return false;}
    }

    return true;

}

void mostrarPrimos(int tope)
{
   for(int i = 0; i <= tope; i++)
    {
    if (isPrimo(i)){ printf("%d es Primo\n", i);}
    }
}


int main() {
    mostrarPrimos(100);
    return 0;
}
