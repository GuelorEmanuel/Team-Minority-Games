using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	 
	private Animator animator;
	private HealthBar playerHealthBar;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		playerHealthBar = GetComponent<HealthBar> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		playerHealthBar.setRedHealthBar (20f);
		animator.SetInteger ("AnimState", 1);
	}
}
