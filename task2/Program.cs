int a = Convert.ToInt32(Console.ReadLine());
int[] n = new int[a];
int zar = 1;
for (int i = 0; i < a; i++)
{
    n[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < a; i++)
{
    zar *= n[i];
}
for (int i = 0; i < a; i++)
{
    if (i > 0) Console.Write("*");
    Console.Write(n[i]);
}
Console.Write(" = " + zar);