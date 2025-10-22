
int[] arr = {1, 2, 3, 4, 5, 6, 7, 8};
Console.WriteLine("Hello, World!");


print(arr); 

static void  print(int[] arr)
{
    foreach(int i in arr)
        Console.Write($"{i}  ");
}

static bool even(int num)
{
    if(num %2 == 0)
        return true;    
    else
        return false;   
}

static bool odd(int num)
{
    if (num % 2 != 0)
        return true;
    else
        return false;
}
