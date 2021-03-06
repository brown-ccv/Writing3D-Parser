using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Plane")]
public class Plane { 

	[XmlAttribute(AttributeName="point")] 
	public string Point; 

	[XmlAttribute(AttributeName="normal")] 
	public string Normal; 
}
