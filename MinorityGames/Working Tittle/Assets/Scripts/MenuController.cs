using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public GameObject loadingImage;
    public Slider loadingBar;
    private AsyncOperation async;
 

    IEnumerator LoadLevelWithBar(string sceneName)
    {
        async = SceneManager.LoadSceneAsync(sceneName);
        while (!async.isDone){
            loadingBar.value = async.progress;
            yield return null;
        }
    }

	public void LoadScene(string sceneName){
		if (sceneName.Equals ("Exit")) {
			Debug.Log ("Quit Called");
			Application.Quit ();
		} else {
            loadingImage.SetActive(true);
            StartCoroutine(LoadLevelWithBar(sceneName));
			Debug.Log ("Load : " + sceneName);
           
			
		}
	}
}
