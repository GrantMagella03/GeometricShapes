using GeometricShapes;

internal class Program
{
    private static void Main(string[] args)
    {
        ooQuad A = new ooQuad(3,4,5,6);
        int perimeter = A.perimeter();
        Console.WriteLine(A.perimeter());
        ooRect B = new ooRect(3, 5);
        Console.WriteLine(B.perimeter());
        Console.WriteLine(B.area());
        ooSquare C = new ooSquare(5);
        Console.WriteLine(C.perimeter());
        Console.WriteLine(C.area());
    }
}