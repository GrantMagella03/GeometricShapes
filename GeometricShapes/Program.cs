using GeometricShapes;

internal class Program
{
    private static void Main(string[] args)
    {
        quad A = new quad(3,4,5,6);
        int perimeter = A.perimeter();
        Console.WriteLine(A.perimeter());
        Rect B = new Rect(3, 5);
        Console.WriteLine(B.perimeter());
        Console.WriteLine(B.area());
        Square C = new Square(5);
        Console.WriteLine(C.perimeter());
        Console.WriteLine(C.area());
    }
}