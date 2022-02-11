using UnityEngine;
using System.Xml.Serialization;

[XmlRoot(ElementName="SoundRoot")]
public class SoundRoot { 

	[XmlElement(ElementName="Sound")] 
	public List<Sound> Sound; 
}
