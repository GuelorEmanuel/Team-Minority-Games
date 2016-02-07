using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	public float maxHealth     = 100f;
	public float currentHealth = 0f;

	public GameObject greenHealthBar;
	public GameObject redHealthBar;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
		if (currentHealth > 0) {
			InvokeRepeating ("decreaseHealth", 1f, 1f);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void decreaseHealth() {
		currentHealth -= 2f;
		float calculatedHealth = currentHealth / maxHealth; // if current health is 80 / 100 = 0.8f
		setGreenHealthBar(calculatedHealth);
	}

	public void setGreenHealthBar(float health) {

		//health vakue 0-1
		greenHealthBar.transform.localScale = new Vector3 (Mathf.Clamp(health,0f,1f),
			greenHealthBar.transform.localScale.y, greenHealthBar.transform.localScale.z);
	}

	public void setRedHealthBar(float health) { //@TODO need more logic for the red health bar decrease
		redHealthBar.transform.localScale = new Vector3 (Mathf.Clamp(health,0f,1f),
			redHealthBar.transform.localScale.y, redHealthBar.transform.localScale.z);
		
	}
}
