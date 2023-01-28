namespace ArrayTask;
class Program
{
    static void Main(string[] args)
    {
        //Task1();
        //Task2();
        //Task3();
        //Task4();
        //Task12();
        //Task11();
        //Task6();
        //Task7();
        //Task8();
        //Task9();
        //Task10();
        //Task5();

    }
    static void Task1()
    {
        byte size;
        int number;
        Console.WriteLine("Welcome!");
        l1:
        Console.Write("Enter the size of array:");
        if (byte.TryParse(Console.ReadLine(), out size) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        Console.WriteLine("Enter the elements of array: ");
        int[] myArr = new int[size];
        for(int i = 0; i < size; i++)
        {
            l3:
            Console.Write($"myArr[{i}]= ");
            if (int.TryParse(Console.ReadLine(),out myArr[i]) == false)
            {
                Console.WriteLine("ERROR: It is not number");
                goto l3;
            }
            //myArr[i] = Convert.ToInt32(Console.ReadLine());
            
        }
        l2:
        Console.Write("Enter a number for comparison:");
        if(int.TryParse(Console.ReadLine(),out number) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l2;
        }
        for(int i = 0; i < size; i++)
        {
            if (myArr[i] < number)
            {
                Console.Write($"{myArr[i]} ");
            }
            if (myArr[i] == number)
            {
                Console.WriteLine($"same numbers: {myArr[i]} = {number} ");
            }
        }
    }

    static void Task2()
    {
        byte size;
        int number;
        byte count = 0;
        int average = 0;
        Console.WriteLine("Welcome!");
    l1:
        Console.Write("Enter the size of array:");
        if (byte.TryParse(Console.ReadLine(), out size) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        int[] arr = new int[size];
        Console.WriteLine("Enter the elements of array:");
        for(int i = 0; i < size; i++)
        {
            l2:
            Console.Write($"arr[{i}] = ");
            if(int.TryParse(Console.ReadLine(),out arr[i]) == false)
            {
                Console.WriteLine("ERROR: It is not number");
                goto l2;
            }
        }
        l3:
        Console.Write("Enter a number for comparison: ");
        if(int.TryParse(Console.ReadLine(),out number) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l3;
        }
        for(int i = 0; i < size; i++)
        {
            if (arr[i] < number)
            {
                Console.Write($"{arr[i]} ");
                count++;
                average = average + arr[i];
            }
        }
        Console.WriteLine($"\nResult: {average/count}");


    }

    static void Task3()
    {
        byte size;
        byte count = 0;
        int number;
        double result = 1;
        Console.WriteLine("Welcome!");
        l1:
        Console.Write("Enter the size of array: ");
        if(byte.TryParse(Console.ReadLine(),out size) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        int[] arr = new int[size];
        Console.WriteLine("Enter the elements of array:");
        for(int i = 0; i < size; i++)
        {
            l2:
            Console.Write($"arr[{i}]= ");
            if(int.TryParse(Console.ReadLine(),out arr[i]) == false)
            {
                Console.WriteLine("ERROR: It is not number");
                goto l2;
            }
        }
        l3:
        Console.Write("Enter a number for comparison: ");
        if(int.TryParse(Console.ReadLine(),out number) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l3;
        }
        Console.Write("Result: ");
        for(int i = 0; i < size; i++)
        {
            if (arr[i] > number)
            {
                Console.Write($"{arr[i]} ");
                count++;
                result = result * arr[i];
            }
           
        }
        
        result = Math.Pow(result, (1.0/count));

        Console.WriteLine($"\nResult:{result}");
    }

    static void Task4()
    {
        byte size,number;
        int count = 0;
        
        Console.WriteLine("Welcome!");
        l1:
        Console.Write("Enter the size of array: ");
        if(byte.TryParse(Console.ReadLine(),out size) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        Console.WriteLine("Enter elements of array: ");
        int[] arr = new int[size];
        for(int i = 0; i < size; i++)
        {
            l2:
            Console.Write($"arr[{i}]= ");
            if(int.TryParse(Console.ReadLine(),out arr[i]) == false)
            {
                Console.WriteLine("ERROR: It is not number");
                goto l2;
            }
        }
        l3:
        Console.Write("Enter a number for comparison: ");
        if(byte.TryParse(Console.ReadLine(),out number) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l3;
        }
        Console.WriteLine($"Elements greater than {number}: ");
        
        for(int i = 0; i < size; i++)
        {
            if (arr[i] > number)
            {
                Console.Write($"{arr[i]} ");
                count++;
            }
        }
        int[] arr2 = new int[count];
        int index = 0;
       
        for(int i = 0; i < size; i++)
        {
            if (arr[i] > number)
            {
                arr2[index] = arr[i];
                index++;
            }
        }
        Array.Sort(arr2);
        Array.Reverse(arr2);
        Console.WriteLine("\nResult:");
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{arr2[i]} ");
        }
    }

    static void Task12()
    {
        int[] arr = new int[20];
        double edediOrta = 0;
        double hendesiOrta = 1;
        for(int i = 0; i < 20; i++)
        {
            l1:
            Console.Write($"arr[{i}]= ");
            if(int.TryParse(Console.ReadLine(),out arr[i]) == false)
            {
                Console.WriteLine("ERROR: It is not number");
                goto l1;
            }
        }
        for(int i = 0; i < 10; i++)
        {
            edediOrta = edediOrta + arr[i];
        }
        edediOrta = edediOrta / 10;
        Console.WriteLine($"Ededi orta: {edediOrta}");
        for(int i = 10; i < 20; i++)
        {
            hendesiOrta = hendesiOrta * arr[i];
        }
        hendesiOrta = Math.Pow(hendesiOrta, 1.0 / 10);
        Console.WriteLine($"Hendesi orta: {hendesiOrta}");
    }

    static void Task11()
    {
        Console.WriteLine("Welcome!");
        
        Random random = new Random();
        
        l1:
        Console.Write("Enter the size of array: ");
        byte size;
        if(byte.TryParse(Console.ReadLine(),out size) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        int[] arr = new int[size];
        Console.WriteLine("Elements of array are: ");
        for(int i = 0; i < size; i++)
        {
            arr[i] = random.Next(0, 100);
            Console.Write($"{arr[i]} ");

        }
        Array.Sort(arr);
        Array.Reverse(arr);
        Console.WriteLine("\nThe result is: ");
        for(int i = 0; i < size; i++)
        {
            Console.Write($"{arr[i]} ");
        }

    }

    static void Task6()
    {
        byte size;
        l1:
        Console.Write("Enter the size of array: ");
        if(byte.TryParse(Console.ReadLine(),out size) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        int[] arr1 = new int[size];
        Console.WriteLine("Enter the elements of array:");
        for(int i = 0; i < size; i++)
        {
            l2:
            Console.Write($"arr1[{i}]= ");
            if(int.TryParse(Console.ReadLine(),out arr1[i]) == false)
            {
                Console.WriteLine("ERROR: It is not number");
                goto l2;
            }
        }
        
        
        int[] arr2 = new int[size];
        
        for(int i = 0; i < size; i++)
        {
            arr2[i] = arr1[i] * arr1[i];
        }
        Console.WriteLine("Result: ");
        for(int i = 0; i < size; i++)
        {
            Console.Write($"{arr2[i]} ");
        }
    }

    static void Task7()
    {
        byte size;
        l1:
        Console.Write("Enter the size of array: ");
        if (byte.TryParse(Console.ReadLine(), out size) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        int[] arr1 = new int[size];
        Console.WriteLine("Enter the elements of array:");
        for (int i = 0; i < size; i++)
        {
            l2:
            Console.Write($"arr1[{i}]= ");
            if (int.TryParse(Console.ReadLine(), out arr1[i]) == false)
            {
                Console.WriteLine("ERROR: It is not number");
                goto l2;
            }
        }
        Array.Sort(arr1);
        Console.WriteLine($"Max element: {arr1[size - 1]}, Min element: {arr1[0]}");
        
        double edediOrta = 0;
        double hendesiOrta = 1;

        edediOrta = (arr1[0] + arr1[size - 1])/2;
        hendesiOrta = Math.Pow((arr1[0] * arr1[size - 1]), 1.0 / 2);
        Console.WriteLine($"Ededi orta: {edediOrta} \nHendesi orta: {hendesiOrta}");

    }

    static void Task8()
    {
        int[] arr1 = new int[14];
        int[] arr2 = new int[14];
        
        byte count = 0;
        for(int i = 0; i < 14; i++)
        {
            l1:
            Console.Write($"arr1[{i}]= ");
            if(int.TryParse(Console.ReadLine(),out arr1[i]) == false)
            {
                Console.WriteLine("ERRO :It is not number");
                goto l1;
            }
        }
        for(int i = 0; i < 14; i++)
        {
            l2:
            Console.Write($"arr2[{i}]= ");
            if(int.TryParse(Console.ReadLine(),out arr2[i]) == false)
            {
                Console.WriteLine("ERROR: It is not number");
                goto l2;
            }
        }
        for(int i = 0; i < 14; i++)
        {
            if ((arr1[i] * arr2[i]) >0)
            {
                count++;
            }
        }
        int[] arr3 = new int[count];
        for(int i = 0; i < count; i++)
        {
            if ((arr1[i] * arr2[i]) > 0)
            {
                arr3[i] = arr1[i] * arr2[i];
            }
            
        }
        Console.WriteLine("Positive results are: ");
        for(int i = 0; i < count; i++)
        {
            Console.Write($"{arr3[i]} ");
        }
    }

    static void Task9()
    {
        Console.WriteLine("Welcome!");
        int[] arr1 = new int[25];
        double[] arr2 = new double[25];
        Console.WriteLine("Enter the elements of array:");
        for(int i = 0; i < 25; i++)
        {
            l1:
            Console.Write($"arr[{i}]= ");
            if(int.TryParse(Console.ReadLine(),out arr1[i]) == false)
            {
                Console.WriteLine("ERROR: It is not number");
                goto l1;
            }
        }
        for(int i = 0; i < 8; i++)
        {
            arr2[i] = Math.Pow(arr1[i], 2);
        }
        for(int i = 8; i < 25; i++)
        {
            arr2[i] = arr1[i] / 4;
        }
        for(int i = 0; i < 25; i++)
        {
            Console.Write($"{arr2[i]} ");
        }
    }

    static void Task10()
    {
        byte size;
        Console.WriteLine("Welcome!");
        l1:
        Console.Write("Enter the size of array: ");
        if(byte.TryParse(Console.ReadLine(),out size) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        int[] arr = new int[size];
        Console.WriteLine("Enter the elements of array:");
        for(int i = 0; i < size; i++)
        {
            l2:
            Console.Write($"arr[{i}]= ");
            if(int.TryParse(Console.ReadLine(),out arr[i]) == false)
            {
                Console.WriteLine("ERROR: It is not number");
                goto l2;
            }
        }
        int max = arr[0];
        
        for(int i = 0; i < size; i++)
        {
            if (arr[i] < 0)
            {
                if (max > 0)
                {
                    max = arr[i];
                }
                else
                {
                    arr[i] = arr[i] * (-1);
                    max = max * (-1);
                    if (arr[i]<max)
                    {
                        max = arr[i];
                    }
                    max = max * (-1);
                }
            }
        }
        Console.WriteLine($"Max negative number: {max}");
        
        
        
        
        
       


        
        
    }

    static void Task5()
    {
        byte size,number;
        l1:
        Console.Write("Enter the size of array: ");
        if(byte.TryParse(Console.ReadLine(),out size) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l1;
        }
        int[] arr = new int[size];
        Console.WriteLine("Enter the elements of array:");
        for(int i = 0; i < size; i++)
        {
            l2:
            Console.Write($"arr[{i}]= ");
            if(int.TryParse(Console.ReadLine(),out arr[i]) == false)
            {
                Console.WriteLine("ERROR: It is not number");
                goto l2;
            }
        }
        l3:
        Console.Write("Enter the number for comparison: ");
        if(byte.TryParse(Console.ReadLine(),out number) == false)
        {
            Console.WriteLine("ERROR: It is not number");
            goto l3;
        }
        Console.WriteLine($"The elements smaller than {number}:");
        for(int i = 0; i < size; i++)
        {
            if (arr[i] < number)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        int max = arr[0];
        for(int i = 0; i < size; i++)
        {
            if (arr[i] < number)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
        }
        Console.WriteLine($"\nMax element: {max}");
        
        
        
    }


    
}

