using System;

class Calificacion
{
    private double _nota;

    public double Nota
    {
        get
        {
            return _nota;
        }

        set
        {
            if (value >= 0 && value <= 100)
            {
                _nota = value;
            }
            else
            {
                Console.WriteLine("Nota inválida");
            }
        }
    }

    static void Main()
    {
        Console.Write("Digite la nota: ");
        double nota = Convert.ToDouble(Console.ReadLine());

        Calificacion calificacion = new Calificacion();

        calificacion.Nota = nota;

        Console.WriteLine("Nota final: " + calificacion.Nota);
    }
}
