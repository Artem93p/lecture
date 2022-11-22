// упорядочить массив 154326711


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 }; // МАССИВ

void PrintArray(int[] array) // МЕТОД
{
    int count = array.Length; // получение кол ва элементов
    for (int i = 0; i < count; i++) // цикла
    {
        Console.Write($"{array[i]} "); // показываем на экране
    }
    Console.WriteLine(); // пустая строка
}
void SelecrionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++) // этот блок кода ищет минимальную позицию
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];  // меняем местами
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }
}

PrintArray(arr);
SelecrionSort(arr);

PrintArray(arr);