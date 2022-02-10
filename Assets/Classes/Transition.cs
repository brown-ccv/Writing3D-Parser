[XmlRoot(ElementName="Transition")]
public class Transition { 

	[XmlElement(ElementName="Visible")] 
	public bool Visible; 

	[XmlAttribute(AttributeName="duration")] 
	public int Duration; 

	[XmlText] 
	public bool Text; 

	[XmlElement(ElementName="MoveRel")] 
	public MoveRel MoveRel; 

	[XmlElement(ElementName="LinkChange")] 
	public LinkChange LinkChange; 

	[XmlElement(ElementName="Scale")] 
	public double Scale; 

	[XmlElement(ElementName="Movement")] 
	public Movement Movement; 

	[XmlElement(ElementName="Sound")] 
	public Sound Sound; 

	[XmlElement(ElementName="Color")] 
	public double Color; 
}