// int num1 = 5;
//  double num2 = 2.34;

//  string word = "Good morning!";
//  bool check = true;

// int num1 = 5;
// int num2 = 8;

// Console.WriteLine("My numbers are " + num1 + " and " + num2 + " And it is good!");
// Console.WriteLine($"My numbers are {num1} and {num2} and it is good!");

// Console.Write("Input a number: "); 
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Your number is " + num);

// Seminar 1

// Task 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли перваое число квадратом второго.

/*Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)
{
    Console.WriteLine("Yes!");
}
else 
{
    Console.WriteLine("No!");
}
*/
// Task 2. Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

/*Console.Write("Input a positive number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current <= number)
{
    Console.Write(current + " ");
    current++; 
}
*/

// Homework
// Task 2. Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

/*Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine(num2);
}
*/

// Task 3. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.WriteLine("максимальное ->"  + max);
*/
// Task 6.  Напишите программу, которая на вход принимает число и выдаёт,
//  является ли число чётным (делится ли оно на два без остатка).
 
/*Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}
*/

// Task 8. Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.


/*Console.Write("Number:");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;
bool not  = true;
Console.WriteLine("Чётные числа от 1 до " + num);
while (current <= num)
{
if (current % 2 != 1)
{
Console.Write(current + ", ");
not = false;
}
current++;
}
if (not)
{
Console.WriteLine("Нет чётных чисел");
}
*/    