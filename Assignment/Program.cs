int count = 10;
int number = 1;
for (int i = 0; i <= 10; i++)
{
    for (int j = count; j > 0; j--)
    {
        Console.Write(" ");
    }
    count--;
    for(int k=1; k<=number; k++)
    {
        Console.Write(k+" ");
    }
    number++;
    Console.WriteLine();
}

int count1 = 1;
int number1 = 10;

for(int i = 0;i <= 10; i++)
{
    for(int j = 1; j <= count1;j++)
    {
        Console.Write(" ");
    }
    count1++;
    for(int k=1; k<=number1;k++)
    {
        Console.Write(k + " ");
    }
    number1--;
    Console.WriteLine();
}
