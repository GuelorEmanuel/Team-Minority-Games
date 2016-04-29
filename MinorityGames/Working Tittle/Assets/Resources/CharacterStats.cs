using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class CharacterStats {

	[XmlAttribute("name")]
    public string charName { get; set; }

	[XmlElement("Health")]
	public int health { get; set; }

    [XmlElement("LighAttackMax")]
	public int lightAttackMax { get; set; }

    [XmlElement("LighAttackMin")]
	public int lightAttackMin { get; set; }

    [XmlElement("HeavyAttackMax")]
	public int heavyAttackMax { get; set; }

    [XmlElement("HeavyAttackMin")]
	public int heavyAttackMin { get; set; }

    [XmlElement("ShieldMax")]
	public int shieldMax { get; set; }

    [XmlElement("ShieldMin")]
	public int shieldMin { get; set; }

    [XmlElement("Critical")]
	public float critical { get; set; }
}
