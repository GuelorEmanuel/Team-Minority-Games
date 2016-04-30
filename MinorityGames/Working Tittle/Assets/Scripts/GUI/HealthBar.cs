using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	private float maxHealth        = 100f;
	private float currentHealth    = 0f;
	private float currentRedHealth = 0f;
	private GameObject playerLogoImage;
	private Sprite spr;

	bool isDead;
	bool isDamaged;

	public GameObject greenHealthBar;
	public GameObject redHealthBar;

	// Use this for initialization
	void Start () {
		currentHealth    = maxHealth;
		currentRedHealth = maxHealth;
	
	}

	// Update is called once per frame
	void Update () {}

	public void decreaseHealth(float damage) {
		if (currentHealth > 0) {
			if (currentHealth < currentRedHealth) {
				
				currentRedHealth -= damage;
				float calculatedRedHealth = currentRedHealth / maxHealth;
				setRedHealthBar (calculatedRedHealth);
			} else {
				currentHealth -= damage;
				float calculatedHealth = currentHealth / maxHealth; // if current health is 80 / 100 = 0.8f
				setGreenHealthBar (calculatedHealth);
			}
		}
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

	public void setLogo(string typeOfPlayer, string logoName) {
		spr = Resources.Load<Sprite> (logoName);
		playerLogoImage = GameObject.Find(typeOfPlayer);
		//Resources.Load<Sprite>(newImageTitle);
		playerLogoImage.GetComponent<Image>().sprite = spr;

		Debug.Log(playerLogoImage.GetComponent<Image>().sprite);
	}
}
