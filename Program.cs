Console.WriteLine("##Nulable Types ##\n");


int? x = 20;
int? y = 40;
int? z = x * y;

Console.WriteLine(z);
Console.ReadLine();

int? b = null;
if (b.HasValue)
{
Console.WriteLine($"b = {b.Value}");
}
else
{
    Console.WriteLine("b não possui um valor");
}

    
