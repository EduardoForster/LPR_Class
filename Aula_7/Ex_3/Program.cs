using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] distancia = new int[5, 5]
        {
            { 0, 524, 521, 882, 518 },
            { 524, 0, 434, 586, 412 },
            { 521, 434, 0, 429, 120 },
            { 882, 586, 429, 0, 850 },
            { 518, 412, 120, 850, 0 }
        };
        string[] cidades = { "São Paulo", "Rio de Janeiro", "Belo Horizonte", "Brasília", "Vitória" };

        while (true)
        {
            Console.WriteLine("Informe a cidade de origem (Vitória, Belo Horizonte, Rio de Janeiro, São Paulo, Brasília):");
            string origem = Console.ReadLine();
            Console.WriteLine("Informe a cidade de destino (Vitória, Belo Horizonte, Rio de Janeiro, São Paulo, Brasília):");
            string destino = Console.ReadLine();

            int indiceOrigem = Array.IndexOf(cidades, origem);
            int indiceDestino = Array.IndexOf(cidades, destino);

            if (indiceOrigem >= 0 && indiceDestino >= 0)
            {
                if (indiceOrigem == indiceDestino)
                {
                    Console.WriteLine("Você escolheu a mesma cidade para origem e destino.");
                    continue;
                }
                Console.WriteLine($"A distância entre {cidades[indiceOrigem]} e {cidades[indiceDestino]} é de {distancia[indiceOrigem, indiceDestino]} km.");
            }
            else
            {
                Console.WriteLine("Cidade de origem ou destino inválida. Tente novamente.");
            }
        }
    }
}
