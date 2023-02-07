Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool palindrome = Palindrome(number);

Console.WriteLine(palindrome ? "ДА" : "НЕТ");
bool Palindrome(int num)
{
    int firstDigit = num / 10000;
    int fiveDigit = num % 10;
    int temp = firstDigit - fiveDigit;
    int secondDigit = temp / 100;
    int fourDigit = temp % 10;
    bool result;
    if (firstDigit == fiveDigit || secondDigit == fourDigit)
        result = true;
    else
        result = false;
    return result;
}
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// number = number < 0 ? -number : number;
// if (number < 9999 || number > 99999)
// {
//     Console.WriteLine("Число не является пятизначным.");
//     return;
// }
// if (Palindrome(number) == true) Console.WriteLine($"Число {number} является палиндромом.");
// else
//     Console.WriteLine($"Число {number} не является палиндромом.");
// bool Palindrome(int num)
// {
//     int num1;
//     int num2;
//     int num4;
//     int num5;
//     bool result;
//     num1 = num / 10000;
//     num2 = num / 1000 % 10;
//     num4 = num / 10 % 10;
//     num5 = num % 10;
//     if (num1 == num5 && num2 == num4)
//         result = true;
//     else
//         result = false;
//     return result;
// }