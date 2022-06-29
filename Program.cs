// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string massage)
{
    System.Console.Write(massage);
    string param = Console.ReadLine();
    return int.Parse(param);
}
int [] InsertNumber (int MNumber)
{
    int [] CountNumbers = new int [MNumber];
    for (int i=0; i < MNumber; i++)
    {
        CountNumbers[i]=Prompt($"Введите {i+1} из {MNumber}: ");
    }
    return CountNumbers;
}
int SearchNumberOfPositive (int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
        {
            result++;
        }
    }
    return result;
}

int MNumber = Prompt ("Определите количество чисел для ввода: ");
int [] myarray = InsertNumber(MNumber);
System.Console.WriteLine($"Количество положительных чисел: {SearchNumberOfPositive(myarray)}");