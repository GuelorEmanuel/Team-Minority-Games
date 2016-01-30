using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour {

	public Image selectedCharacter;
	public Sprite[] char_collection;
	public AudioClip[] voices;
	public AudioSource audioSource = new AudioSource ();

	public void ChangeCharacterSelected(int index){
		selectedCharacter.sprite = char_collection [index];
		AudioClip clip = voices[index];
		audioSource.clip = clip;
		audioSource.Play ();
		Debug.Log (index);
	}
}
