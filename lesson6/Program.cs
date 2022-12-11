//Напишите программу,которая перевернет одномерный массив
//(последний элемент будет на первом месте,а первый на последнем)


using static Common.Helper;


// Console.WriteLine(int.MaxValue);
// int[] array = CreateRandomArray();
// PrintArray(array);
// Console.WriteLine();
// int[] reversed = ReverseArray(array);
// PrintArray(reversed);



//Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101
//3 -> 11
//2 -> 1)

// int[] array = CreateRandomArray();
// Console.Write("[  " );
// PrintArray(array);
// Console.Write("]  " );
// int[] reversed = ReverseArray(array);
// Console.WriteLine();
// Console.Write("[  " );
// PrintArray(reversed);
// Console.Write("]  " );

int number = InputInt1();
int[] cubeTable = GetCubeTable(number);
PrintArray(cubeTable);
