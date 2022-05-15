int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
int ingreso;
int n = 1; //arranco en uno para contar el acierto desde esta instancia
do
{
    Console.Write("Ingrese un numero para adivinar el numero secreto: ");
    ingreso = int.Parse(Console.ReadLine());
    if (ingreso > numeroSecreto)
    {
        Console.WriteLine("El numero ingresado es mayor al numero secreto. Siga probando");
        n += 1;
    }
    else if (ingreso < numeroSecreto)
    {
        Console.WriteLine("El numero ingresado es menor al numero secreto. Siga probando");
        n += 1;
    }
}
while (numeroSecreto != ingreso);
Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}"); 
Console.WriteLine($"Lo has logrado en {n} intentos!!");
