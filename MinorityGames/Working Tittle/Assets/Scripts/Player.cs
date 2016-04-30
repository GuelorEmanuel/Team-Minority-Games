using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	private HealthBar playerHealthScript;
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		playerHealthScript = GetComponent<HealthBar>();


	}
	
	// Update is called once per frame
	void Update () {
		playerHealthScript.decreaseHealth (1f);
		animator.SetInteger ("AnimState", 1);

	}
}
