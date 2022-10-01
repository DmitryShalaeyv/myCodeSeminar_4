/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/

void Task_25 () {
Console.Write ("Введите целое число - > ");
string num_str = Console.ReadLine();
int num1 = Convert.ToInt32(num_str);

Console.Write ("Введите второе целое число - > ");
num_str = Console.ReadLine();
int num2 = Math.Abs(Convert.ToInt32(num_str));

Console.WriteLine($"{num1} в степени {num2} = {Pow(num1, num2)}");

}

int Pow(int n1, int pow)
{
int result = 1;

for(int i = 1; i <= pow; i++)
    result *= n1;

return result;
}

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/

void Task_27 () {
    Console.Write("Input number -> ");

    string number_str = Console.ReadLine();

    int sum = 0;
    for(int i = 0; i < number_str.Length; i++)
      sum += Convert.ToByte("" + number_str[i]);
    

    Console.WriteLine($"Сумма цифр {sum}");
}

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.*/

void Task_29 () {

    int[] arr = {1, 3, 8, -5, 6, -1, 8, 15};

    PrintArray(arr);
  }

  void PrintArray(int[] arr)
  {
    string str = "[";
    for(int i = 0; i < arr.Length - 1; i++)
    {
      str += arr[i] + ",";
    }
    str += arr[arr.Length - 1] + "]";

    Console.WriteLine(str);
  }

Console.WriteLine("Введите номер задачи -> ");
string num_str = Console.ReadLine();
int num = int.Parse(num_str);
if(num == 25)
{
    Task_25();
    return;
} 
if(num == 27)
{
    Task_27();
    return;
} 
if(num == 29)
{
    Task_29();
    return;
} 
else Console.WriteLine("Неверный номер задачи");