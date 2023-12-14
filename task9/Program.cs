int a = Convert.ToInt32(Console.ReadLine());
int [] n = new int [a];


for (int i = 0; i < a; i++)
{
  n[i] = Convert.ToInt32(Console.ReadLine());
}
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
for (int i = b; i < c; i++)
{
  System.Console.WriteLine(n[i] + " ");
}

