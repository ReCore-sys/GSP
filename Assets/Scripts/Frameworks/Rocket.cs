using Frameworks;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public ShipBase Ship;
    private List<Stage> partIds = new();
    private string currentCockpit;

    // Start is called before the first frame update
    private void Start()
    {
        Ship = new ShipBase
        {
            Stages = new List<Stage>(){
            new()
            {
                Engine = new Engine
                {
                    Base = new ShipPartBase
                    {
                        ID = "enginenull",
                        DisplayName = "No Engine",
                        Description = "You have no engine equipped",
                        Weight = 0,
                        ExecuteCoroutine = false,
                        ExecuteOnFrame = null,
                        Cost = 0,
                        Models = new List<Model>()
                        {
                            new()
                            {
                                ModelName = "no_engine",
                                Offset = new Vector3(0,0,0)
                            }
                        }
                    },
                    FuelConsumption = 0,
                    Thrust = 0,
                },
                Tank = new FuelTank
                {
                    Base = new ShipPartBase
                    {
                        ID = "tanknull",
                        DisplayName = "No Tank",
                        Description = "You have no tank equipped",
                        Weight = 0,
                        ExecuteCoroutine = false,
                        ExecuteOnFrame = null,
                        Cost = 0,
                        Models = new()
                        {
                            new Model()
                            {
                                Offset = new(0,0,0),
                                ModelName = "no_tank"
                            }
                        }
                    },
                    Capacity = 0,
                    Remaining = 0,
                }
            },},
            Cockpit = new Cockpit
            {
                Base = new()
                {
                    ID = "cockpitnull",
                    DisplayName = "No Cockpit",
                    Description = "You have no cockpit equipped",
                    Weight = 0,
                    ExecuteCoroutine = false,
                    ExecuteOnFrame = null,
                    Cost = 0,

                    Models = new List<Model>()
                    {
                        new()
                        {
                            ModelName = "no_engine",
                            Offset = new Vector3(0,
                                0,
                                0)
                        }
                    }
                },
                IncomeMultiplier = 0
            },
        };
        Debug.Log("Ship Built!");
    }

    // Update is called once per frame
    private void Update()
    {
        if (currentCockpit != Ship.Cockpit.Base.ID)
        {
            currentCockpit = Ship.Cockpit.Base.ID;
            Debug.Log("Cockpit changed to " + currentCockpit);
        }

        for (int I = 0; I < partIds.Count; I++)
        {
            if (partIds[I].Engine.Base.ID != Ship.Stages[I].Engine.Base.ID)
            {
                Debug.Log("Engine changed to " + Ship.Stages[I].Engine.Base.ID);
                partIds[I].Engine.Base.ID = Ship.Stages[I].Engine.Base.ID;
            }
            if (partIds[I].Tank.Base.ID != Ship.Stages[I].Tank.Base.ID)
            {
                Debug.Log("Tank changed to " + Ship.Stages[I].Tank.Base.ID);
                partIds[I].Tank.Base.ID = Ship.Stages[I].Tank.Base.ID;
            }
        }
    }
}