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
		animator.SetInteger ("AnimState", 1); // this is a test please stand by
		setPlayerHealthAvatar ("PlayerLogo","Logo_Riceball"); // this is a test please stand by

	}

	public void takeDamage(float amount) {
		playerHealthScript.decreaseHealth (amount);
	}

	public void setPlayerHealthAvatar(string typeOfPlayer, string logoName) {
		playerHealthScript.setLogo (typeOfPlayer, logoName);
	}

	public void lightPunch() {
		animator.SetInteger ("AnimState", 1);
	}

	public void setIdleState() {
		animator.SetInteger ("AnimState", 0);
	}

}
