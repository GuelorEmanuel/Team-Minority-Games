using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour {

	public Image selectedCharacter;
	public Sprite[] char_collection;
	public AudioClip[] voices;
	public AudioSource audioSource = new AudioSource ();
    public int characterIndex;
    private CharacterStatsContainer stats;
    

    void Start(){
        stats = CharacterStatsContainer.LoadAll();
    }

    public int GetCharacterIndex(){
        return this.characterIndex;
    }

    public void SetCharacterIndex(int value) {
        this.characterIndex = value;
        ChangeCharacterSelected();
    }

    public void ChangeCharacterSelected(){
        ChangeCharaterSprite();
        ChangeCharaterSound();
        ChangeCharacterStats();
	}

    public void ChangeCharaterSprite(){
        selectedCharacter.sprite = char_collection[characterIndex];
    }

    public void ChangeCharaterSound(){
        AudioClip clip = voices[characterIndex];
        audioSource.clip = clip;
        audioSource.Play();
    }

    public void ChangeCharacterStats(){
        Debug.Log(stats.charStats[characterIndex].charName);
    }

    public void SaveCharacterSelected()
    {
        string toJson = JsonUtility.ToJson(stats.charStats[characterIndex]);
        PlayerPrefs.SetString("SelectedCharacter", toJson);
    }
}
