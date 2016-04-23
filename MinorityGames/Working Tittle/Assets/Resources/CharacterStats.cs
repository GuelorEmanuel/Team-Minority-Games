using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class CharacterStats {

	[XmlAttribute("name")]
	public string charName;

	[XmlElement("Health")]
	public int health;

	[XmlElement("LighAttackMax")]
	public int lightAttackMax;

	[XmlElement("LighAttackMin")]
	public int lightAttackMin;

	[XmlElement("HeavyAttackMax")]
	public int heavyAttackMax;

	[XmlElement("HeavyAttackMin")]
	public int heavyAttackMin;

	[XmlElement("ShieldMax")]
	public int shieldMax;

	[XmlElement("ShieldMin")]
	public int shieldMin;

	[XmlElement("Critical")]
	public float critical;
}
