namespace Models
{
    public class Vehicle
    {
        // Propietats
        public string Model { get; set; }
        public string Marca { get; set; }
        public int Any { get; set; }
        public double VelocitatMaxima { get; set; }

        // Constructor per inicialitzar el vehicle
        public Vehicle(string model, string marca, int any, double velocitatMaxima)
        {
            Model = model;
            Marca = marca;
            Any = any;
            VelocitatMaxima = velocitatMaxima;
        }

        // Mètode per mostrar informació sobre el vehicle
        public void MostrarInformacio()
        {
            Console.WriteLine($"Vehicle: {Marca} {Model}, Any: {Any}, Velocitat màxima: {VelocitatMaxima} km/h");
        }
    }
}
