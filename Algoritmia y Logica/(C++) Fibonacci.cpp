/*
    Escribe un programa que imprima los 50 primeros números de la sucesión
    de Fibonacci empezando en 0.

    La serie Fibonacci se compone por una sucesión de números en
    la que el siguiente siempre es la suma de los dos anteriores.

    0, 1, 1, 2, 3, 5, 8, 13...
 */

#include <iostream>
using namespace std;

void fibonacci() {
    long long a = 0, b = 1;

    cout << a << endl;
    cout << b << endl;

    for (int i = 2; i < 50; i++) {
        b = a + b;
        a = b - a;
        cout << b << endl;
    }
}

int main() {
    fibonacci();
    return 0;
}
