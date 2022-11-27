
string[] A = new string[5];
A[0] = "jsdkjf"; A[1] = "404"; A[2] = "HelloWorld!";
A[3] = string.Empty; A[4] = "200"; A[5] = "NAME";
Console.WriteLine($" {A[0]}, {A[1]}, {A[2]}, {A[3]}, {A[4]}, {A[5]} ");

int x = new Random().Next(1, 4);
string[] B = new string[x];
if (x == 3)
{
    int b1 = new Random().Next(0, 5);
    B[0] = A[b1];
    int b2 = new Random().Next(0, 5);
    B[1] = A[b2];
    int b3 = new Random().Next(0, 5);
    B[2] = A[b3];
    Console.WriteLine($"{B[0]}, {B[1]}, {B[2]} ");
}
if (x == 2)
{
    int b1 = new Random().Next(0, 5);
    B[0] = A[b1];
    int b2 = new Random().Next(0, 5);
    B[1] = A[b2];
    Console.WriteLine($"{B[0]}, {B[1]}");
}
if (x == 1)
{
    int b1 = new Random().Next(0, 5);
    B[0] = A[b1];
    Console.WriteLine($"{B[0]}");
}
