using System;
using System.Linq;
using static Utils.Arrays;

namespace Frameworks
{
    public abstract partial class PartLibrary
    {
        /// <summary>
        /// Does exactly what it says on the tin
        /// </summary>
        /// <param name="Id">The id of the cockpit you want</param>
        /// <returns>The cockpit with the id or null</returns>
        public static Cockpit GetCockpit(string Id)
        {
            foreach (Cockpit Cockpit in Cockpits)
            {
                if (Cockpit.Base.ID == Id)
                {
                    return Cockpit;
                }
            }

            return null;
        }

        /// <summary>
        /// Does exactly what it says on the tin
        /// </summary>
        /// <param name="Id">The id of the engine you want</param>
        /// <returns>The engine with the id or null</returns>
        public static Engine GetEngine(string Id)
        {
            foreach (Engine Engine in Engines)
            {
                if (Engine.Base.ID == Id)
                {
                    return Engine;
                }
            }

            return null;
        }

        /// <summary>
        /// Does exactly what it says on the tin
        /// </summary>
        /// <param name="Id">The id of the tank you want</param>
        /// <returns>The tank with the id or null</returns>
        public static FuelTank GetTank(string Id)
        {
            foreach (FuelTank Tank in Tanks)
            {
                if (Tank.Base.ID == Id)
                {
                    return Tank;
                }
            }

            return null;
        }

        /// <summary>
        /// Wanna build a rocket? This is how.<br/>
        /// First ID must be a cockpit, the rest must be pairs of engines and tanks. Order matters. <br/>
        /// Example: "cockpitmedium", "enginesmall1", "tanksmall", "enginesmall2", "tanksmall"
        /// </summary>
        /// <param name="Partids">A list of part ids</param>
        /// <returns>A built rocket</returns>
        /// <exception cref="ArgumentNullException">One of the IDs supplied wasn't valid</exception>
        public static ShipBase BuildRocket(string[] Partids)
        {
            // Double check the array isn't null. Probably not needed but better safe than sorry
            if (Partids == null) throw new ArgumentNullException(nameof(Partids));
            // Make sure it at least has 3 elements
            if (Partids.Length < 3) throw new ArgumentException("Partids must have at least one element", nameof(Partids));
            // Since the first element is solo but the rest are pairs, check it has an odd number of elements
            if (Partids.Length % 2 == 0) throw new ArgumentException("Partids must have an odd number of elements", nameof(Partids));
            // Make a new ship
            ShipBase UnderConstruction = new();
            Cockpit Possiblecockpit = GetCockpit(Partids[0]);
            // Make sure the first element is a valid cockpit
            if (Possiblecockpit == null) throw new ArgumentNullException(nameof(Possiblecockpit) + "\nCheck if the first element is a cockpit ID");

            UnderConstruction.Cockpit = Possiblecockpit;

            // Split the remaining elements into pairs
            string[][] Chunked = ChunkArray(Partids[1..], 2);
            foreach (string[] Chunk in Chunked)
            {
                // For each pair, check both tank and engine IDs are valid, then make a new stage and add them
                Engine Possibleengine = GetEngine(Chunk[0]);
                if (Possibleengine == null)
                    throw new ArgumentNullException(nameof(Possibleengine) +
                                                    "\nMake sure engines and tanks are in the correct order");
                FuelTank PossibleTank = GetTank(Chunk[1]);
                if (PossibleTank == null)
                    throw new ArgumentNullException(nameof(PossibleTank) +
                                                    "\nMake sure engines and tanks are in the correct order");

                UnderConstruction.Stages.Add(new Stage()
                {
                    Engine = Possibleengine,
                    Tank = PossibleTank
                });
            }

            return UnderConstruction;
        }
    }
}