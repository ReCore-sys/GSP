using System.Collections;
using System.Collections.Generic;

namespace Frameworks
{
    /// <summary>
    /// Base class for all ship parts
    /// This is just to make it easier to give all ship parts common components
    /// </summary>
    public class ShipPartBase
    {
        public static ShipPartBase Instance { get; } = new();
        public string ID; // ID of the part. Should be formatted as <PartType><ID>
        public string DisplayName; // The name of this item, as it will appear in the game.
        public string Description; // A description of this item, as it will appear in the game.
        public float Weight; // Weight in tonnes
        public bool ExecuteCoroutine; // Whether or not to execute the coroutine
        public IEnumerator ExecuteOnFrame; // A coroutine that will be executed on every frame if ExecuteCoroutine is true
        public int Cost; // The cost of this item in credits
        public List<Model> Models; // Models for the part
    }
}