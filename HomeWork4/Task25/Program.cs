Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());

if ( B == 0 )
    {
        Console.WriteLine("Степень числа равна: "+ 1);
    }
else
    {
        for (int Adegree = 0; B > Adegree; Adegree++)
            {
                Adegree++;
                A = A * A;
                Console.WriteLine("Степень числа равна: "+ A);
            }
    }
