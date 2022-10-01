//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.Write(" наибольшая цифра числа ");
int[] arr = new int[99];
Random rand = new Random();
for (int i = 10; i < arr.Length; i++)
{
    arr[i] = rand.Next(99);
    Console.WriteLine(arr[i]+" ");
}
int max = arr[10];
for (int i = 10; i < arr.Length; i++)
{
if (arr[i] > max)
{
    max = arr[i];
}
}
Console.WriteLine(" Max:" + max);