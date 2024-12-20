namespace Models
{
    public class Vaixell : Vehicle
    {
        // Propietat específica de Vaixell
        public double Tonnatge { get; private set; }

        // Constructor per inicialitzar el vaixell
        public Vaixell(string model, string marca, int any, double velocitatMaxima, double tonnatge)
            : base(model, marca, any, velocitatMaxima)
        {
            Tonnatge = tonnatge;
        }

        // Implementació del mètode abstracte MostrarInformacio
        public override void MostrarInformacio()
        {
            Console.WriteLine($"Vaixell: {Marca} {Model}, Any: {Any}, Velocitat màxima: {VelocitatMaxima} km/h, Tonnatge: {Tonnatge} tones");
        }
    }
}