using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	private HealthBar playerHealthScript;
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		var playerHealth = GameObject.FindWithTag("PlayerhealthBar");
		playerHealthScript = (HealthBar)playerHealth.GetComponent ("HealthBar");


	}
	
	// Update is called once per frame
	void Update () {
		playerHealthScript.decreaseHealth ();
		animator.SetInteger ("AnimState", 1);

	}
}
