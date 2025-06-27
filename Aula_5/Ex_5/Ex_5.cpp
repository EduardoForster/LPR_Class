#include <iostream>
#include <cmath>
using namespace std;

int main() {
    int horasPorDia, totalHorasSemana = 0, horasAcumuladas = 0, diasNecessarios = 0;
    const int diasUteis = 5; 
    const int objetivoHoras = 1000;
    const double semanasPorMes = 4.5;

    cout << "Digite o número de horas de treinamento: ";
    cin >> horasPorDia;

    totalHorasSemana = horasPorDia * diasUteis;

    while (horasAcumuladas < objetivoHoras) {
        horasAcumuladas += horasPorDia;
        diasNecessarios++;
    }

    int semanasNecessarias = ceil((double)diasNecessarios / diasUteis);
    double mesesNecessarios = (double)semanasNecessarias / semanasPorMes;

    cout << "Total de horas de treinamento: " << totalHorasSemana << " horas" << endl;
    cout << "Você precisará de " << diasNecessarios << " dias para alcançar 1000 horas." << endl;
    cout << "Isso equivale a " << semanasNecessarias << " semanas." << endl;
    cout << "Ou aproximadamente " << ceil(mesesNecessarios) << " meses." << endl;

    return 0;
}