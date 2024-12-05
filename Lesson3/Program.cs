// начинаем работать с функциями.

double CalculateFormula(int a, int b, int c, int d)
{
    double numinate = a * b;
    double denomenator = c + d;
    double result = numinate / denomenator;
    return result;
}

double result = CalculateFormula(4, 4, 6, 6);

System.Console.WriteLine(result);