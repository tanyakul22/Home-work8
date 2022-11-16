const int a=3,b=4;
int [,]array = new int[a,b];
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
           Console.Write( array[i,j]);
        }
        Console.WriteLine();
    }
    int sum=0,c=0;
    for(int j=0;j<array.GetLength(1);j++)
        sum+=array[0,j];
    for(int i=1;i<array.GetLength(0);i++)
    {
      int tsum=0;
      for (int j=0;j<array.GetLength(1);j++)
         tsum+=array[i,j];
      if (tsum<sum)
      {
        sum=tsum;
        c=i;}
    }
    Console.WriteLine("строка:"+ c + " является строкой с наименьшей суммой элементов. Сумма составляет:" + sum);