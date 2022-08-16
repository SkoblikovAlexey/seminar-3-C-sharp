// static int DO(int index){
//     return Math.Pow(index, 3);
// }
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.PI);
// Console.WriteLine(Math.Sqrt(number));
// Console.WriteLine(Math.Round(Math.PI, 3));
// Console.WriteLine(Math.Pow(number, 4));
// int a = number > 1 ? DO(number) : 123;

static int[] createrArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
    }
    return array;
}
static void writeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

static int[] shuffle(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int j = new Random().Next(0, i + 1);
        int number = array[j];
        array[j] = array[i];
        array[i] = number;
    }
    return array;
}

int[] array = createrArray(20);
writeArray(array);
Console.WriteLine(" ");
array = shuffle(array);
writeArray(array);