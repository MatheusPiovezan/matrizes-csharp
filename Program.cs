namespace Course10Exerc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de linhas: ");
            int qLinhas = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de colunas: ");
            int qColunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[qLinhas, qColunas];

            for (int i = 0; i < qLinhas; i++)
            {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < qColunas; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < qLinhas; i++)
            {
                for (int j = 0; j < qColunas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < qLinhas; i++)
            {
                for (int j = 0; j < qColunas; j++)
                {
                    if (matriz[i, j] == numero)
                    {
                        Console.WriteLine($"Position: {i}, {j}");

                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < qLinhas - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < qColunas - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}