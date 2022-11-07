// Алгоритмы сортировки

Console.WriteLine("Введите кол-во элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());

//int[] array = new int[n];


int[] FillArray (int size, int LowLimit, int PowLimit)
{
    int[] filledArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        filledArray[i] = new Random().Next(LowLimit, PowLimit + 1);
    }
    return filledArray;
}

// Сортировка выбором
void SelectionSort (int[] arr)                                              
{
    for (int i = 0; i < n - 1; i++)
    {
        int MinIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (arr[j] < arr[MinIndex])
                MinIndex = j; 
        }
        int temp;
        temp = arr[MinIndex];
        arr[MinIndex] = arr[i];
        arr[i] = temp;
    }
}                                           
// Сортировка пузырьком
void BubbleSort(int[] arr)                                                  
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}
// Быстрая сортировка
void QuickSort(int[] inputArray, int minIndex, int maxIndex)                
{
	if (minIndex >= maxIndex) return;
	int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
	QuickSort(inputArray, minIndex, pivot - 1);
	QuickSort(inputArray, pivot + 1, maxIndex);
	return;
}
// Сортировка подсчетом
void CountingSort(int[] inputArray)
{
            //поиск минимального и максимального значений
    var min = inputArray[0];
    var max = inputArray[0];
    foreach (int element in inputArray)
        {
        if (element > max)
            {
                max = element;
            }
        else if (element < min)
            {
                min = element;
            }
        }
            //поправка
    var correctionFactor = min != 0 ? -min : 0;
    max += correctionFactor;

    var count = new int[max + 1];
    for (var i = 0; i < inputArray.Length; i++)
    {
        count[inputArray[i] + correctionFactor]++;
    }
    var index = 0;
    for (var i = 0; i < count.Length; i++)
    {
        for (var j = 0; j < count[i]; j++)
            {
                inputArray[index] = i - correctionFactor;
                index++;
            }
    }
    return;
}
        
void ShakerSort(int[] listS)
{
    int left = 0,
    right = listS.Length - 1,
    count = 0;

    while (left < right)
    {
        for (int i = left; i < right; i++)
        {
            count++;
            if (listS[i] > listS[i + 1]) Swap(ref listS[i], ref listS[i + 1]);
        }
        right--;

        for (int i = right; i > left; i--)
        {
            count++;
            if (listS[i - 1] > listS[i]) Swap(ref listS[i - 1], ref listS[i]);
        }
        left++;
    }
}

static int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
{
	int pivotIndex = minIndex - 1;
	for (int i = minIndex; i <= maxIndex; i++)
	{
		if (inputArray[i] < inputArray[maxIndex])
		{
			pivotIndex++;
			Swap(inputArray, i, pivotIndex);
		}
	}
	pivotIndex++;
	Swap(inputArray, pivotIndex, maxIndex);
	return pivotIndex;
}
// Замена переменной
static void Swap(int[] inputArray, int leftValue, int rightValue)           
{
	int temp = inputArray[leftValue];
	inputArray[leftValue] = inputArray[rightValue];
	inputArray[rightValue] = temp;
}


int[] array = FillArray(n, 1, 100);

Console.WriteLine();
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");


SelectionSort(array);
Console.WriteLine($"Сортировка выбором: [{string.Join(", ", array)}]");

BubbleSort(array);
Console.WriteLine($"Сортировка пузырьком: [{string.Join(", ", array)}]");

QuickSort(array, 0, array.Length - 1);
Console.Write($"Быстрая сортировка: [{string.Join(", ", array)}]");








Console.ReadLine();