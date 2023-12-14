Console.Write("Your deposit: ");
double dep = Convert.ToDouble(Console.ReadLine());
double dep1 = 0;

if (dep <= 100)
{
    dep1 = dep * 0.05;
}
else if (dep > 100 && dep <= 200)
{
    dep1 = dep * 0.07;
}
else
{
    dep1 = dep * 0.1;
}

dep = dep + dep1;

System.Console.WriteLine(dep);