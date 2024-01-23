using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeCarLibrary;

[Serializable]
[Obsolete("Use another vehicle")]
[VehicleDescription(Description = "The old gray mare, " +
    "she ain't what she used to be")]
internal class HorseAndBuggy
{
}
