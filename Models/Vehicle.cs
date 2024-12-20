namespace Models
{
    public abstract class Vehicle
    {
    // Propietats
        public string Model { get; protected set; }
        public string Marca { get; protected set; }
        public int Any { get; protected set; }
        public double VelocitatMaxima { get; protected set; }

        // Constructor per inicialitzar el vehicle
        protected Vehicle(string model, string marca, int any, double velocitatMaxima)
        {
            Model = model;
            Marca = marca;
            Any = any;
            VelocitatMaxima = velocitatMaxima;
        }

        // Mètode abstracte per mostrar informació
        public abstract void MostrarInformacio();
    }
}
