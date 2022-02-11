using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="ObjectRoot")]
public class ObjectRoot { 

	[XmlElement(ElementName="Object")] 
	public List<Object> Object; 
}
