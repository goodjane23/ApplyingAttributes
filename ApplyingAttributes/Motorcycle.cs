using System.Text.Json.Serialization;

namespace ApplyingAttributes;
internal class Motorcycle
{
    [JsonIgnore]
    public float weightOfCuurentPassengers;

    public bool hasRadioSystem;
    public bool hasHeadSet;
    public bool hasSissyBar;


}
