


using Consola.Class;

public class Program
{
    private static void Main(string[] args)
    {
        CreamosVariables();
        CreamosMatricesYVectores();

        Console.WriteLine("Probando imprimir algo en la pantalla");

        ImpresionDeParametros(args);

        //CapturaDeValoresDelUsuario();
        CreamosAlumnosEImprimimosSuFichaDeDatos();


    }

    private static void CreamosAlumnosEImprimimosSuFichaDeDatos()
    {
        Alumno alumno = new Alumno("Tobias", "Orecchia", 12345678, new DateOnly(2000, 1, 9));
        Console.WriteLine(alumno.ImpresionFichaDeDatos());
        Alumno alumno2 = new Alumno("Enzo", "Lovino", 87654321, new DateOnly(2001, 2, 10));
        Console.WriteLine(alumno2.ImpresionFichaDeDatos());
        Alumno alumno3 = new Alumno("Aquiles", "Fuster", 11223344, new DateOnly(2002, 3, 11));
        Console.WriteLine(alumno3.ImpresionFichaDeDatos());

        Console.WriteLine(Alumno.ImprimirCantidadDeInstancias());
    }

    private static void CreamosMatricesYVectores()
    {
        //creamos un vector de tipo string con 12 elementos
        string[] meses= new string[12] {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
        meses[0] = "ENERO";
        meses[11]= "DICIEMBRE";
        //creamos una matriz de tipo string con 3 filas y 2 columnas
        string[,] nosotros= new string[3,2] {{"Alejandro", "Ramirez"},{"Enzo", "Lovino"},{"Aquiles", "Fuster"}};
        nosotros[0, 0] = "Tobias";
        nosotros[2, 1] = "Orecchia";
        int[] edades= new int[3] {20, 21, 22};
    }

    private static void CapturaDeValoresDelUsuario()
    {
        Console.Write("Ingrese el año de su nacimiento: ");
        string? anio_nacimiento = Console.ReadLine();
        int anio= Convert.ToInt32(anio_nacimiento);
        int edad = DateTime.Now.Year - anio;
        Console.WriteLine($"Usted tiene {edad} años aproximadamente");
    }

    private static void ImpresionDeParametros(string[] args)
    {
        if (args.Length > 1)
            Console.WriteLine($"Hola {args[0]} {args[1]}");
    }

    private static void CreamosVariables()
    {
        //creamos una variable de entera y le asignamos un valor
        int numero = 10;
        // Declaracion de una variable de tipo string y asignamos un valor
        int numero2;
        // Asignamos un valor a la variable numero2
        numero2 = 20;
        int numero3 = 30;
    }
}