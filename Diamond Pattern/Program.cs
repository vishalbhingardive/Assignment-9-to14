Console.WriteLine("Enter Array");
int row=int.Parse(Console.ReadLine());
int col=int.Parse(Console.ReadLine());

int [,] arr=new int[row,col];

for (int i = 1; i <arr.Length; i++)
{
    for(int j = 1; j <= arr.Length-i; j++)
    {
        Console.Write(" ");
    }
    for(int k = 1; k <= i*2-1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();        
}

for(int i = arr.Length; i >=1;i--)
{
    for(int j=1;j<= arr.Length-i; j++)
    {
        Console.Write(" ");
    }
    for(int k=1; k<= 2*i-1;k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}