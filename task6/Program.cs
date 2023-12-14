int a = Convert.ToInt32(Console.ReadLine());
int [] n = new int [a];
int cnt = 0;

for (int i = 0; i < a; i++)
{
  n[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 1; i < a-1; i++)
{
   if(n[i] > n[i+1] && n[i] > n[i-1])cnt++;
}
Console.Write(cnt);