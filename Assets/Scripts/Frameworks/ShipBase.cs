using System.Collections.Generic;

namespace Frameworks
{
    /// <summary>
    /// The summary of all ship parts. All calculations are done here.
    /// <br/>
    /// </summary>
    public class ShipBase
    {
        public List<Stage> Stages = new();
        public Cockpit Cockpit;
    }
}