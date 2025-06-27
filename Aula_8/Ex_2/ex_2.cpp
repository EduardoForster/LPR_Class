#include <iostream>
#include <string>
using namespace std;

struct Livro {
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    float Preco;
};

int main() {
    Livro livros[3];
    float precoTotal = 0;
    int totalPaginas = 0;

    for (int i = 0; i < 3; i++) {
        cout << "Livro " << i + 1 << ":" << endl;
        
        cin.ignore(); 
        cout << "Título: ";
        getline(cin, livros[i].Titulo);

        cout << "Autor: ";
        getline(cin, livros[i].Autor);

        cout << "Ano de Publicação: ";
        cin >> livros[i].AnoPublicacao;

        cout << "Número de Páginas: ";
        cin >> livros[i].NumeroPaginas;

        cout << "Preço: ";
        cin >> livros[i].Preco;

        precoTotal += livros[i].Preco;
        totalPaginas += livros[i].NumeroPaginas;
    }

    float mediaPaginas = totalPaginas / 3.0;

    cout << "\nPreço total dos livros: R$ " << precoTotal << endl;
    cout << "Média de páginas: " << mediaPaginas << endl;

    return 0;
}
