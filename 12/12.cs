Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());
int count;
int reverse = 0;

    while (number > 0 || number < 0)
        {
                
            count = number % 10;
               
            reverse = (reverse * 10) + count;
                 
            number = number / 10;
        }
Console.WriteLine(reverse);