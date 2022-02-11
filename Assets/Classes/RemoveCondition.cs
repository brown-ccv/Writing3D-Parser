using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="RemoveCondition")]
public class RemoveCondition { 

	[XmlElement(ElementName="Position")] 
	public Position Position; 

	[XmlElement(ElementName="Age")] 
	public Age Age; 
}
