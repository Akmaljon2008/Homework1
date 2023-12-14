int a = Convert.ToInt32(Console.ReadLine());
int cnt = 0;
int [] n = new int [a];


for (int i = 0; i < a; i++)
{ 
    n[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < a; i++)
{ 
    cnt=0;
    for (int j = 0; j < a; j++)
    {
        if (i !=j && n[i] == n[j])cnt++;
    }
    if (cnt  == 0){
    System.Console.Write(n[i] + " ");
    }
}