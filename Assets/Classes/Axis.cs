using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="Axis")]
public class Axis { 

	[XmlAttribute(AttributeName="rotation")] 
	public string Rotation; 

	[XmlAttribute(AttributeName="angle")] 
	public double Angle; 
}
