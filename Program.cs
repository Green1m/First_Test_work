// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] arrString;
string[] secString;
arrString = new string[5]; // {"123","rerfdf", "34", "szdfw43", "1"};
for (int j = 0; j < arrString.Length; j++)
    arrString[j] = Console.ReadLine ()!;
secString = new string[arrString.Length];
int count = 0;
for (int i = 0; i < arrString.Length; i++)
    {
    if (arrString[i].Length <= 3){
        secString[count] = arrString[i];
        count ++;
        }
    }
Console.WriteLine("[" + string.Join(" ", arrString) + "]" + "[" + string.Join(" ", secString) + "]");