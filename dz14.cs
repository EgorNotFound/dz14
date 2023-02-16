//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int [] array = GetArray (12 ,-9 , 9 );
int sum =0;
Console.WriteLine(String.Join(" ", array));
int [] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int [size];
    for (int i =0; i< size;i++ )
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}
for (int i = 0; i< array.Length;i++){
    if(i%2!=0){
        sum = sum + array[i];
    }
}
Console.WriteLine("Сумма элементов на нечетных индексах: " + sum);

