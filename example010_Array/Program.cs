//int [] array = {1, 12, 31, 4, 15, 16, 17, 18 };
//int [] array = new int [10]; - создай новый массив, где будет 10 элементов (по умолчанию все элементы 0)
void FillArray(int[] collection)// FillArray - наименование метода. collection - аргумент
{
    int n = collection.Length;
    int index = 0;
    while(index < n)
    {
        collection[index] = new Random().Next(1, 10); //из случайных чисел 
        index ++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int [] array = new int[10];
FillArray(array);
PrintArray(array);

//Первый вариант:
//int [] array = new int [10];

//int n = array.Length;
//int find = 4;

//int index = 0;
//while (index < n)
//{
//    if(array[index] == find)
//    {
//        Console.WriteLine(index);
//    }
//    index++;
//}