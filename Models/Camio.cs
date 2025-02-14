namespace Models
{
    public class Camio : Vehicle
    {
        public int CargaMaxima { get; private set; }

        //CAMIO MODIFICACIOOOOOO


        //PROBAAAAAAAAAAAAAA

        public Camio(string model, string marca, int any, double velocitatMaxima, int cargaMaxima)
            : base(model, marca, any, velocitatMaxima)
        {
            CargaMaxima = cargaMaxima;
        }

        public override void MostrarInformacio()
        {
            Console.WriteLine($"Camio: {Marca} {Model}, Any: {Any}, Velocitat màxima: {VelocitatMaxima} km/h, CargaMaxima: {CargaMaxima}");
        }
    }
}
