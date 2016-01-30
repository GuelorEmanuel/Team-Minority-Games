using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArray;

	private AudioSource audioSource;

	void Awake(){
		DontDestroyOnLoad (gameObject);
		Debug.Log ("Don't destroy on load : " + name);
	}

	void Start(){
		audioSource = GetComponent<AudioSource> ();
		audioSource.loop = true;
		audioSource.Play ();
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnLevelWasLoaded(int level){

		AudioClip clip = levelMusicChangeArray[level];

		Debug.Log ("Playing clip: " + clip);

		if (clip) {
			audioSource.clip = clip;
			audioSource.loop = true;
			audioSource.Play();
		}
	}
}
