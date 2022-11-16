// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] array1 = new string[4] {"1234", "1567", "-2", "computer science" };
string[] array2 = new string[array1.Length];
void secarray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count]=array1[i];
            count++;
        }
    }

}
void printrightarray(string[] array)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}
secarray(array1, array2);
printrightarray(array2);