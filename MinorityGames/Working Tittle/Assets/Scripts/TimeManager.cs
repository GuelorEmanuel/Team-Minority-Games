using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour {

	public float           startTime;
	private string  currentTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		startTime    -= Time.deltaTime;
		currentTime = string.Format ("{0:0.0}", startTime);
		print (currentTime);

		if (startTime <= 0) {
			startTime = 0;
			print ("ROUND IS OVER!");
			IsRoundTimeOver ();
		}
	
	}

	bool IsRoundTimeOver(){
		return false;
	}
}
