int tamanhoMatriz = 0, oQueSomar, reiniciar = 0, valorMinimo = 0, valorMaximo = 0;
int[,] matriz;
int[] vetorResultado;
int diagonalResultado = 0;

void menu()
{
    Console.Write("Qual será o tamanho da matriz? ");
    tamanhoMatriz = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("Qual o valor MÍNIMO a ser utilizado na matriz?");
    valorMinimo = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual o valor MÁXIMO a ser utilizado na matriz?");
    valorMaximo = int.Parse(Console.ReadLine());
    
    do
    {
        Console.WriteLine("Você deseja realizar a soma das linhas, colunas, diagonal1 ou diagonal2?");
        Console.WriteLine("1 - LINHAS");
        Console.WriteLine("2 - COLUNAS");
        Console.WriteLine("3 - DIAGONAL 1");
        Console.WriteLine("4 - DIAGONAL 2");
        oQueSomar = int.Parse(Console.ReadLine());

        if (oQueSomar < 1 || oQueSomar > 4) Console.WriteLine("\n\nERRO: Informe um valor correto!");
    } while (oQueSomar <= 0 || oQueSomar > 4);
}

//CRIAR MATRIZ E VETORES DE RESULTADO
void criarMatrizVetor(int tamanho)
{
    matriz = new int[tamanho, tamanho];
    vetorResultado = new int[tamanho];
}

//POPULAR MATRIZ
void popularMatriz(int tamanho, int min, int max)
{
    Console.WriteLine("\nMatriz ORIGINAL:");
    for (int l = 0; l < tamanho; l++)
    {
        if (l > 0) Console.WriteLine();
        for (int c = 0; c < tamanho; c++)
        {
            matriz[l, c] = new Random().Next(min, max + 1);
            Console.Write(matriz[l, c] + " ");
        }
    };
}

//PASSAR A VARIAVEL oQueSomar COMO PARAMETRO
void somar(int referencia)
{
    Console.WriteLine("\n\nRESULTADO: ");
    if (referencia < 3)
    {
        for (int r = 0; r < tamanhoMatriz; r++)
        {
            for (int c = 0; c < tamanhoMatriz; c++)
            {
                vetorResultado[r] += referencia == 1 ? matriz[r, c] : matriz[c, r];
            }
            Console.Write($"{vetorResultado[r]} ");
        }
    }
    else
    {
        int aux_c = tamanhoMatriz - 1;
        for (int l = 0; l < tamanhoMatriz; l++)
        {
            diagonalResultado += referencia == 3 ? matriz[l, l] : matriz[l, aux_c];
            aux_c--;
        }

        Console.WriteLine(diagonalResultado);
    }
}

//INICIO DO PROGRAMA
do
{
    menu();

    //CRIA A MATRIZ E VETOR DE RESULTADO
    criarMatrizVetor(tamanhoMatriz);

    //POPULA A MATRIZ
    popularMatriz(tamanhoMatriz, valorMinimo, valorMaximo);

    //FAZENDO O CALCULO
    somar(oQueSomar);

    Console.WriteLine("\n\nReiniciar o programa?");
    Console.WriteLine("1 - SIM");
    Console.WriteLine("2 - NÃO");
    reiniciar = int.Parse(Console.ReadLine());
} while (reiniciar == 1);
