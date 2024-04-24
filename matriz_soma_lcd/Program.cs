int tamanho = 3;
int[,] matriz = new int[tamanho, tamanho];
int[] soma_linhas = new int[tamanho];
int[] soma_colunas = new int[tamanho];
int diagonal1 = 0, diagonal2 = 0, i_decrescente = tamanho;

for (int l = 0; l < tamanho; l++)
{
    Console.WriteLine();
    for (int c = 0; c < tamanho; c++)
    {
        matriz[l, c] = new Random().Next(1, 10);
        Console.Write($"{matriz[l, c]} ");
    }
}

Console.WriteLine("\n\nSOMA DE LINHAS:");
for (int l = 0; l < tamanho; l++)
{
    for (int c = 0; c < tamanho; c++)
    {
        soma_linhas[l] += matriz[l, c];
    }
    Console.Write($"{soma_linhas[l]} ");
}

Console.WriteLine("\n\nSOMA DE COLUNAS:");
for (int c = 0; c < tamanho; c++)
{
    for (int l = 0; l < tamanho; l++)
    {
        soma_colunas[c] += matriz[l, c];
    }
    Console.Write($"{soma_colunas[c]} ");
}

Console.WriteLine("\n\nSOMA DE DIAGONAIS:");
int aux_c = tamanho - 1;
for (int l = 0; l < tamanho; l++)
{
    diagonal1 += matriz[l, l];
    diagonal2 += matriz[l, aux_c];
    aux_c--;
}

Console.WriteLine("Diagonal 1 = " + diagonal1);
Console.WriteLine("Diagonal 2 = " + diagonal2);