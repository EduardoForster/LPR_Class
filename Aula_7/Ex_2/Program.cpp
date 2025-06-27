#include <iostream>
using namespace std;

int main() {
    int numeros[10];
    int numero_pesquisa;
    int ocorrencias = 0;

    cout << "Digite 10 números inteiros:" << endl;
    for (int i = 0; i < 10; i++) {
        cout << "Número " << i + 1 << ": ";
        cin >> numeros[i];
    }
    cout << "\nDigite o número que deseja pesquisar no vetor: ";
    cin >> numero_pesquisa;
    cout << "\nO número " << numero_pesquisa << " foi encontrado nas posições: ";
    for (int i = 0; i < 10; i++) {
        if (numeros[i] == numero_pesquisa) {
            cout << i << " ";
            ocorrencias++;
        }
    }
    if (ocorrencias > 0) {
        cout << "\nNúmero de ocorrências: " << ocorrencias << endl;
    } else {
        cout << "\nNúmero não encontrado no vetor." << endl;
    }
    return 0;
}
