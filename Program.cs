



Console.Write("Son kiriting :");

int inputNum = Convert.ToInt32(Console.ReadLine());

int chec = 4  ;

for(int i = inputNum;chec>0;i++ )
{
    int tupChecker=0;
    for(int j=1;j<=i;j++)
    {
       if(i%j==0)
       {
         tupChecker++;
       }
       
       
    }
    if(tupChecker==2)
       {
        Console.WriteLine(i);
        chec--;
       }
 
}

