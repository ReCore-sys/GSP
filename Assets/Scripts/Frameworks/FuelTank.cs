namespace Frameworks
{
    /// <summary>
    /// Simply put, the fuel tank controls the max amount of fuel the ship can take off with
    /// </summary>
    public class FuelTank
    {
        internal static FuelTank Instance { get; } = new();

        public ShipPartBase Base;
        public float Capacity; // Capacity in liters
        public float Remaining; // Remaining in liters
    }
}