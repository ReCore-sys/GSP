using System.Collections.Generic;
using UnityEngine;

namespace Frameworks
{
    public abstract partial class PartLibrary
    {
        public static readonly FuelTank[] Tanks = {new()
            {
                Base = new ShipPartBase
                {
                    DisplayName = "Small tank",
                    Description = "A fuel tank that holds fuel",
                    Cost = 100,
                    ID = "tanksmall",
                    Weight = 1.5f,
                    Models = new List<Model>()
                    {
                        new()
                        {
                            ModelName = "SmallTank",
                            Offset = new Vector3(0, 0)
                        }
                    }
                },
                Capacity = 5000,
                Remaining = 5000
            },
            new(){
                Base = new ShipPartBase
                {
                    DisplayName = "Medium tank",
                    Description = "A fuel tank that holds more fuel",
                    Cost = 500,
                    ID = "tankmedium",
                    Weight = 2.7f,
                    Models = new List<Model>()
                    {
                        new()
                        {
                            ModelName = "MediumTank",
                            Offset = new Vector3(0, 0)
                        }
                    }
                },
                Capacity = 6000,
                Remaining = 6000
            }
        };

        public static readonly Engine[] Engines = { new()
            {
                Base = new ShipPartBase
                {
                    ID = "enginesmall1",
                    DisplayName = "WL-1",
                    Description = "A small pressure-fed engine, typically used in vacuums due to its low thrust",
                    Weight = 0.1f,
                    ExecuteCoroutine = false,
                    ExecuteOnFrame = null,
                    Cost = 500,
                    Models = new List<Model>()
                    {
                        new()
                        {
                            ModelName = "SmallEngine1",
                            Offset = new Vector3(0,0)
                        }
                    }
                },
                FuelConsumption = 20,
                Thrust = 1500
            },
            new()
            {
                Base = new ShipPartBase
                {
                    ID = "enginesmall2",
                    DisplayName = "WL-1b",
                    Description = "A modified variant of the WL-1 consisting of two engines mounted together, operating in tandem",
                    Weight = 0.2f,
                    ExecuteCoroutine = false,
                    ExecuteOnFrame = null,
                    Cost = 800,
                    Models = new List<Model>()
                    {
                        new()
                        {
                            ModelName = "SmallEngine2",
                            Offset = new Vector3(0,0)
                        }
                    }
                },
                FuelConsumption = 50,
                Thrust = 3000
            },
            new(){Base = new ShipPartBase
                {
                    ID = "enginemedium1",
                    DisplayName = "ML-25",
                    Description = "A medium engine typically used to propel smaller rockets through the lower atmosphere. The ML-25 is the first engine to incorporate a gas generator system, allowing it to ingest more fuel at a faster rate into the combustion chamber ",
                    Weight = 1f,
                    ExecuteCoroutine = false,
                    ExecuteOnFrame = null,
                    Cost = 1000,
                    Models = new List<Model>()
                    {
                        new()
                        {
                            ModelName = "MediumEngine1",
                            Offset = new Vector3(0,0)
                        }
                    }
                },
                FuelConsumption = 800,
                Thrust = 85000
            }
        };

        public static readonly Cockpit[] Cockpits = { new()
            {
                Base = new ShipPartBase
                {
                    ID = "cockpitsmall",
                    DisplayName = "Small cockpit",
                    Description = "A small cockpit",
                    Weight = 1f,
                    ExecuteCoroutine = false,
                    ExecuteOnFrame = null,
                    Cost = 800,
                    Models = new List<Model>()
                    {
                        new()
                        {
                            ModelName = "SmallCockpit",
                            Offset = new Vector3(0,0)
                        }
                    }
                },
                IncomeMultiplier = 1
            },
            new(){Base = new ShipPartBase
                {
                    ID = "cockpitmedium",
                    DisplayName = "Medium cockpit",
                    Description = "A medium cockpit",
                    Weight = 1.5f,
                    ExecuteCoroutine = false,
                    ExecuteOnFrame = null,
                    Cost = 1000,
                    Models = new List<Model>()
                    {
                        new()
                        {
                            ModelName = "MediumCockpit",
                            Offset = new Vector3(0,0)
                        }
                    }
                },
                IncomeMultiplier = 1.5f}
        };
    }
}