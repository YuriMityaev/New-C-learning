
// string[] names = {"Nikita", "Nastya", "Egor"};

// names[0] = "New Name";
// System.Console.WriteLine(names[0]);

// Необходимо задать массив и написать программу 
// принимающую число и проверяющая если ли число в массиве.

int[]   array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}