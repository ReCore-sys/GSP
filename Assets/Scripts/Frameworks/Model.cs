using UnityEngine;

namespace Frameworks
{
    public class Model
    {
        internal static Model Instance { get; } = new();
        public string ModelName; // The name of the .obj to load. the extension will bre stripped
        public Vector3 Offset; // The offset of the model from the center of the ship
    }
}