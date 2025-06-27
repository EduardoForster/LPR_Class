#include <iostream>
using namespace std;

int main() {
    int numero, quadrado, soma = 0;

    cout << "Digite um número: ";
    cin >> numero;

    quadrado = numero * numero;

    cout << "O quadrado de " << numero << " é: " << quadrado << endl;

    while (quadrado > 0) {
        soma += quadrado % 10; 
        quadrado /= 10;        
    }

    cout << "A soma dos dígitos do quadrado é: " << soma << endl;

    return 0;
}