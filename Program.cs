using System;
public class Prog
{
    public static void Main(string[] args)
    {
        
        int num = int.Parse(Console.ReadLine());

        int nechet = 0, efive=0,  makc=int.MinValue,makc2=0;
        for (int i = 0; i < num; i++)
        {
            int a = int.Parse(Console.ReadLine());
            //Проверка на нечетность
            if (a % 2 != 0)
            {
                nechet++;
            }
            //Оканчивается ли элемент на 5
            if (a % 10 == 5)
            {
                efive++;
            }
            //Второй максимум
            if (a > makc)       
            {
                makc2=makc;
                makc = a;
            }
            else if(a>makc2 && a!=makc)
            {
                makc2 = a;
            }
            
        
        }
        if (nechet == num)
        {
            Console.WriteLine("Все элементы нечетные");
        }
        else
        {
            Console.WriteLine("Не все элементы нечетные");
        }
        Console.WriteLine("Кол-во элементов оканчивающихся на 5:" +" "+ efive);
        
       
        Console.WriteLine("Второй максимум: " + makc2);


    }
}

