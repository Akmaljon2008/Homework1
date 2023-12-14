int a = Convert.ToInt32(Console.ReadLine());
int [] n = new int [a];
int m = 999;
int index = 0;
for (int i = 0; i < a; i++)
{
  n[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < a; i++)
{
    if(n[i]<m)
    {
        m=n[i];
        index = i;
    }
}
Console.Write(index);