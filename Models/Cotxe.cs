namespace Models
{
    public class Cotxe : Vehicle
    {
        public int NombrePortes { get; private set; }

        public Cotxe(string model, string marca, int any, double velocitatMaxima, int nombrePortes)
            : base(model, marca, any, velocitatMaxima)
        {
            NombrePortes = nombrePortes;
        }

        public override void MostrarInformacio()
        {
            Console.WriteLine($"Cotxe: {Marca} {Model}, Any: {Any}, Velocitat màxima: {VelocitatMaxima} km/h, Portes: {NombrePortes}");
        }
    }
}