// Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
const int coeff = 0;
const int constant = 1;
const int x_coords = 0;
const int y_coords = 1;
const int Line1 = 1;
const int Line2 = 2;

double[] lineData1 = InputLineData(Line1);
double[] lineData2 = InputLineData(Line2);

if (ValidateLines(lineData1, lineData1))
{
    double[] coord = Findcoords(lineData1, lineData1);
    System.Console.WriteLine($"точка пересечений уравнений y= {lineData1[coeff]}*x +{lineData1[constant]} и y= {lineData2[coeff]}*x +{lineData2[constant]} ");
System.Console.WriteLine($"имеет координаты ({coord[x_coords]},{coord[y_coords]})");
}

double ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

double[] InputLineData(int numberofline)
{
    double[] lineData = new double[2];
    lineData[coeff] = ReadInt($"введите коеффициент для {numberofline} прямой > ");
    lineData[constant] = ReadInt($"введите константу для {numberofline} прямой > ");
    return lineData;
}
double[] Findcoords(double[] lineDa1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[x_coords] = (lineData1[constant] - lineData2[constant]) / (lineData1[coeff] - lineData2[coeff]);
    coord[y_coords] = (lineData1[constant] * coord[x_coords] + lineData1[constant]);
    return coord;
}
bool ValidateLines(double[] lineDa1, double[] lineData2)
{
    if (lineData1[coeff] == lineData2[coeff])
    {
        if (lineData1[constant] == lineData2[constant])
        {
            System.Console.WriteLine("прямые совпадают");
            return false;
        }
        else
        {
            System.Console.WriteLine("прямые параллельны");
            return false;
        }
    }
    return true;
}