/* Я не понял задание, нужно чтобы программа сама создала случайный массив,
 или чтобы человек ввёл массив, а программа обрамила массив в скобки?*/


/* Эта часть кода для самостоятельного ввода массива
Console.WriteLine ("Введите числа массива, разделяя их запятой: ");
string array = Console.ReadLine();
Console.WriteLine ("[" + array + "]");
*/


/* Эта часть кода создаёт случайный массив с числами в диапазлне от 0 до 20*/
int [] numbers = new int[8];
Console.Write("[");
for (int i = 0; i < numbers.Length; i++)
    {
       
        numbers [i] = new Random().Next(0, 21);
        Console.Write(" " + numbers[i] + ", ");
        
    }
Console.Write("]");