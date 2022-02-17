using UnityEngine;
using System.Xml.Serialization;
using System.Collections.Generic;

[XmlRoot(ElementName="Group")]
public class Group { 

	[XmlElement(ElementName="Objects")] 
	public List<Objects> Objects; 

	[XmlAttribute(AttributeName="name")] 
	public string Name; 
}
