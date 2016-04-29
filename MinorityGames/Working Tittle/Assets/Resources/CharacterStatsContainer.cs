using UnityEngine;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;


[XmlRoot("CharacterStats")]
public class CharacterStatsContainer {

	[XmlArray("Characters")]
	[XmlArrayItem("Character")]
	public List<CharacterStats> charStats = new List<CharacterStats>();

	public static CharacterStatsContainer LoadAll() {
		TextAsset _xml = Resources.Load("stats") as TextAsset;

		XmlSerializer serializer = new XmlSerializer(typeof(CharacterStatsContainer));
		StringReader reader = new StringReader(_xml.text);
		CharacterStatsContainer stats = serializer.Deserialize(reader) as CharacterStatsContainer;
		reader.Close();

		return stats;
	}
}