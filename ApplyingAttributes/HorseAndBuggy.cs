
using System.Xml.Serialization;

namespace ApplyingAttributes;

[XmlRoot(Namespace = "Http://www.MyCompany.com"),
       Obsolete("Use another vehicle")]
internal class HorseAndBuggy
{
    public HorseAndBuggy()
    {
            
    }
}
