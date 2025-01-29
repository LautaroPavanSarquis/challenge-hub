/*
  Escribe una función que reciba dos palabras (String) y retorne
  verdadero o falso (Bool) según sean o no anagramas.

  - Un Anagrama consiste en formar una palabra reordenando TODAS
    las letras de otra palabra inicial.
  - NO hace falta comprobar que ambas palabras existan.
  - Dos palabras exactamente iguales no son anagrama.
*/

#include <iostream>
#include <map>
using namespace std;

bool isAnagrama(string palabra1, string palabra2){

     if (palabra1.length() != palabra2.length()) {
        return false;
    }


    map<char, int>map1,map2;



      for (char letra : palabra1) {
        map1[letra]++;
        }

        for (char letra : palabra2) {
            map2[letra]++;
        }

        return map1==map2;
}


int main() {

 string palabra1, palabra2;

    cout << "Primer palabra: ";
    cin >> palabra1;

    cout << "Segunda palabra: ";
    cin >> palabra2;

    if (isAnagrama(palabra1, palabra2)) {
        cout << "Son anagramas" << endl;
    } else {
        cout << "No son anagramas" << endl;
    }

    return 0;
}





