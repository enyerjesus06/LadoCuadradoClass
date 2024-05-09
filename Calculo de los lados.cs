



public class Class1
{
    public void Calladocuadrado()
    
    {

        //Declarar las Variables: lado, perimetro, constante...

        int lado = 0;
        int perimetro = 0;
        int constante = 4;
        string linea = string.Empty;

        Console.WriteLine("Ingrese la longitud del lado del cuadrado: ");
            linea = Console.ReadLine();
            lado = Convert.ToInt32(linea);

        perimetro = (lado * constante);

        Console.WriteLine($"El perímetro del cuadrado es: { perimetro } ");
    
    
    }



}

