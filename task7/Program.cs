int a = Convert.ToInt32(Console.ReadLine());
int [] n = new int [a];
int second = 0;
int f = 0;
for (int i = 0; i < a; i++)
{
  n[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < a-1; i++)
{
   if(n[i] > 0 && n[i+1] > 0 || n[i] < 0 &&  n[i+1]<0){
    f = n[i];
    second = n[i+1];
   }

}
System.Console.WriteLine(f + " " + second );
