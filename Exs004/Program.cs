int [, ,] array=new int[2,2,2];
 List<int> nums= new List<int>();
 for (int i=0;i<90;i++)
 nums.Add(i+10);
 for (int i=0;i<array.GetLength(0);i++)
 {

    for (int j=0;j<array.GetLength(1);j++)
    {
        for (int k=0;k<array.GetLength(2);k++)
        {
            if(nums.Count==0)
            array[i,j,k]=0;
            else
            {
               int temp=new Random().Next(nums.Count);
               array[i,j,k]=nums[temp];
               nums.RemoveAt(temp);
            }
        }
    }
 }
 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k ++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
        }
    }