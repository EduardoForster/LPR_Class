#include <iostream>
using namespace std;

void calcularMediaPares() {
    int quantidade, numero, soma = 0, contagem = 0;
    cout << "Digite a quantidade de numeros: ";
    cin >> quantidade;

    for (int i = 0; i < quantidade; i++) {
        cout << "Digite um numero: ";
        cin >> numero;
        if (numero % 2 == 0) { 
            soma += numero;
            contagem++;
        }
    }

    if (contagem > 0) {
        double media = static_cast<double>(soma) / contagem;
        cout << "A media aritmetica dos numeros pares e: " << media << endl;
    } else {
        cout << "Nenhum numero par foi digitado." << endl;
    }
}

void calcularSomaImparesMultiplosDeTres() {
    int soma = 0;
    for (int i = 51; i <= 500; i += 2) { 
        if (i % 3 == 0) {
            soma += i;
        }
    }
    cout << "A soma dos numeros impares multiplos de 3 entre 50 e 500 e: " << soma << endl;
}

void somarDigitosDoQuadrado() {
    int numero;
    cout << "Digite um numero: ";
    cin >> numero;
    int quadrado = numero * numero;
    int soma = 0;

    while (quadrado > 0) {
        soma += quadrado % 10; 
        quadrado /= 10; 
    }

    cout << "A soma dos digitos do quadrado e: " << soma << endl;
}

int main() {
    int opcao;

    do {
        cout << "Menu:" << endl;
        cout << "1. Calcular media aritmetica de numeros pares" << endl;
        cout << "2. Calcular soma de impares multiplos de 3 entre 50 e 500" << endl;
        cout << "3. Somar digitos do quadrado de um numero" << endl;
        cout << "0. Sair" << endl;
        cout << "Escolha uma opcao: ";
        cin >> opcao;

        switch (opcao) {
            case 1:
                calcularMediaPares();
                break;
            case 2:
                calcularSomaImparesMultiplosDeTres();
                break;
            case 3:
                somarDigitosDoQuadrado();
                break;
            case 0:
                cout << "Saindo..." << endl;
                break;
            default:
                cout << "Opcao invalida! Tente novamente." << endl;
        }
    } while (opcao != 0);

    return 0;
}