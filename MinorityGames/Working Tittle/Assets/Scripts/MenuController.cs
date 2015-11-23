using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	public void LoadScene(string sceneName){
		if (sceneName.Equals ("Exit")) {
			Debug.Log ("Quit Called");
			Application.Quit ();
		} else {
			Debug.Log ("Load : " + sceneName);
			Application.LoadLevel (sceneName);
		}
	}
}
