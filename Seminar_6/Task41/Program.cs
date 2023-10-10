double ReadNumber(string message)
{
    System.Console.WriteLine(message);
    return double.Parse(Console.ReadLine());
}

double k1 = ReadNumber("Введите k1");
double k2 = ReadNumber("Введите k2");
double b1 = ReadNumber("Введите b1");
double b2 = ReadNumber("Введите b2");


double PointX(double k1, double k2, double b1, double b2)
{
    double x = (b2-b1)/(k1-k2);
    return x;
    
}

double PointY(double k1, double k2, double b1, double b2)
{
    
    double y = (k1*b2-b1*k2)/(k1-k2);
    return y;
}




double pointX = PointX(k1, k2, b1, b2);
double pointY = PointY(k1, k2, b1, b2);
System.Console.WriteLine(pointX+"; "+pointY);