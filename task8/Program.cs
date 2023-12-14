int a = Convert.ToInt32(Console.ReadLine());
int [] n = new int [a];
int cnt = 0;

for (int i = 0; i < a; i++)
{
  n[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < a; i++)
{
  if (n[i] %2== 0){
    System.Console.WriteLine(i + " ");
  }
}
