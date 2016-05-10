using UnityEngine;
using System.Collections;

public class PlayerInputScript : MonoBehaviour
{
	private Player player;

	void Start ()
	{
		// Get the player object
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}


	void OnGUI()
	{
		int windowWidth = Screen.width;
		int windowHeight = Screen.height;

		if (GUI.Button(new Rect(10, windowHeight - 160, 150, 30), "Light Attack"))
		{
			player.LightAttack();
		}
		if (GUI.Button(new Rect(10, windowHeight - 120, 150, 30), "Heavy Attack"))
		{
			player.HeavyAttack();
		}
		if (GUI.Button(new Rect(10, windowHeight - 80, 150, 30), "Block"))
		{
			player.Block();
		}
		if (GUI.Button(new Rect(10, windowHeight - 40, 150, 30), "Special Attack"))
		{
			player.SpecialAttack();
		}

	}

}
