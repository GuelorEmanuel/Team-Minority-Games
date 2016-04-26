using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("CharacterStats")]
public class CharacterStatsContainer {

	[XmlArray("Characters")]
	[XmlArrayItem("Character")]
	public List<CharacterStats> charStats = new List<CharacterStats>();

	public static CharacterStatsContainer Load() {
		TextAsset _xml = Resources.Load("stats") as TextAsset;

		XmlSerializer serializer = new XmlSerializer(typeof(CharacterStatsContainer));
		StringReader reader = new StringReader(_xml.text);
		CharacterStatsContainer stats = serializer.Deserialize(reader) as CharacterStatsContainer;
		reader.Close();

		return stats;
	}
}