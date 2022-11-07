const int N = 1000;                                     // размер матрицы 1000 на 1000
const int THREADS_NUMBER = 10;                          // количество потоков (много тоже плохо: больше времени будет уходить на создание потока)

int[,] serialMulRes = new int[N, N];                    // результат выполнения умножения матриц в однопотоке (последовательное умножение)
int[,] threadMulRes = new int[N, N];                    // результат параллельного умножения матриц

int[,] firstMatrix = MatrixGenerator(N, N);
int[,] secondMatrix = MatrixGenerator(N, N);

SerialMatrixMul(firstMatrix, secondMatrix);
PrepareParallelMatrixMul(firstMatrix, secondMatrix);
Console.WriteLine(EqualityMatrix(serialMulRes, threadMulRes));



int[,] MatrixGenerator(int rows, int columns)           // Рандромное заполнение матрицы
{
    Random _rand = new Random();
    int[,] res = new int[rows, columns];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = _rand.Next(-100, 100);
        }
    }
    return res;
}

void SerialMatrixMul(int[,] a, int[,] b)                // Умножение матриц
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножить такие матрицы");

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                serialMulRes[i, j] += a[i, k] * b[k, j];
            }
        }
    }
}

void PrepareParallelMatrixMul(int[,] a, int[,] b)           // Параллельное умножение матриц
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножить такие матрицы");         // проверка на возможность умножения
    int eachThreadCalc = N / THREADS_NUMBER;                                                            // количество вычислений на 1 потоке
    Thread[] arr = new Thread[2];
    var threadsList = new List<Thread>();                           // Коллекция/список (как массив, только лучше) потоков
    for (int i = 0; i < THREADS_NUMBER; i++)                        // создаем коллекцию потоков
    {
        int startPos = i * eachThreadCalc;                      // стартовая позиция
        int endPos = (i + 1) * eachThreadCalc;                  // позиция окончания
        if (i == THREADS_NUMBER - 1) endPos = N;                //если последний поток

        threadsList.Add(new Thread(() => ParallelMatrixMul(a, b, startPos, endPos)));          // объявляем поток и задаем ему функцию
        threadsList[i].Start();                 // запускаем поток
    }
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        threadsList[i].Join();
    }
}

void ParallelMatrixMul(int[,] a, int[,] b, int startPos, int endPos)  // Умножение матриц
{
    for (int i = startPos; i < endPos; i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                threadMulRes[i, j] += a[i, k] * b[k, j];
            }
        }
    }
}

bool EqualityMatrix(int[,] fmatrix, int[,] smatrix)         // Сравнение двух матриц
{
    bool res = true;

    for (int i = 0; i < fmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < fmatrix.GetLength(1); j++)
        {
            res = res && (fmatrix[i, j] == smatrix[i, j]);
        }
    }

    return res;
}

Console.ReadLine();

