#include <iostream>
using namespace std;

const int TAM = 3;

void lerMatriz(int matriz[TAM][TAM], char nome) {
    cout << "Digite os valores da matriz " << nome << " (3x3):\n";
    for (int i = 0; i < TAM; i++) {
        for (int j = 0; j < TAM; j++) {
            cout << nome << "[" << i << "][" << j << "]: ";
            cin >> matriz[i][j];
        }
    }
}

void multiplicarMatrizes(int A[TAM][TAM], int B[TAM][TAM], int resultado[TAM][TAM]) {
    for (int i = 0; i < TAM; i++) {
        for (int j = 0; j < TAM; j++) {
            resultado[i][j] = 0;
            for (int k = 0; k < TAM; k++) {
                resultado[i][j] += A[i][k] * B[k][j];
            }
        }
    }
}

void exibirMatriz(int matriz[TAM][TAM]) {
    cout << "Resultado de A * B:\n";
    for (int i = 0; i < TAM; i++) {
        for (int j = 0; j < TAM; j++) {
            cout << matriz[i][j] << "\t";
        }
        cout << endl;
    }
}

int main() {
    int A[TAM][TAM], B[TAM][TAM], resultado[TAM][TAM];

    lerMatriz(A, 'A');
    lerMatriz(B, 'B');

    multiplicarMatrizes(A, B, resultado);

    exibirMatriz(resultado);

    return 0;
}
