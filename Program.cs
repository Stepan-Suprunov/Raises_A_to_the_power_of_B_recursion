// Возвести А в целую степень В с помощью рекурсии


int Pow(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    
    return a * Pow(a, b-1);
}

int A = 3;
int B = 5;

Console.Write(Pow(A, B));