Console.WriteLine("Enter N");
int N = Convert.ToInt16(Console.ReadLine());
int index = 1;
for (int i = index; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
