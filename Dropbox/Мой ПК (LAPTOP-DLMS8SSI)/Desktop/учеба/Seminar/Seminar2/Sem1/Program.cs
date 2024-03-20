Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

Console.Write("Введите число: ");

int userNum = Convert.ToInt32(Console.ReadLine());

string findNum = "Нет";

for (int i = 0; i < array.Length; i++) // Специальное свойство, которое просчитывает количество элементов
{
    array[i] = new Random().Next(1,20);
    Console.Write(array[i] + " ");

    if(array[i] == userNum)
    {
        findNum = "Да";
    }
}

Console.Write(findNum);
