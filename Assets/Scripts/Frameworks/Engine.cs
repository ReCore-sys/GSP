namespace Frameworks
{
    /// <summary>
    /// The engine controls how fast the ship moves and how fast it burns through fuel
    /// </summary>
    public class Engine
    {
        public ShipPartBase Base;
        public float FuelConsumption; // Fuel consumed in tonnes / second
        public int Thrust; // Acceleration in newtons
    }
}