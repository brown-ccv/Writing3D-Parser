using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Clicks")]
public class Clicks { 

	[XmlElement(ElementName="NumClicks")] 
	public NumClicks NumClicks; 

	[XmlElement(ElementName="Any")] 
	public object Any; 
}
