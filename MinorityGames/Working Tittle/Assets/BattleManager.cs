using UnityEngine;
using System.Collections;
using System;

public class BattleManager : MonoBehaviour
{
	public bool paused;

	private ArrayList players;
	private int currentTurn;

	void Start ()
	{
		paused = false;
		currentTurn = 0;
		players = new ArrayList();

		// Insert players into the list as per their turn order
		GameObject mainPlayer = GameObject.FindGameObjectWithTag("Player");

		if (mainPlayer != null)
			AddPlayerToTurnOrder(0, mainPlayer.GetComponent<Player>());
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!paused && players.Count > 0)
		{
			// Check if the current players turn is completed
			if ( ((TurnEntity)(players[currentTurn])).FinishedTurn() )
			{
				// Reset the current players turn
				((TurnEntity)(players[currentTurn])).ResetTurn();

				// Increment the turn count
				if (++currentTurn >= players.Count)
					currentTurn = 0;

				// Start the next players turn
				((TurnEntity)(players[currentTurn])).TakeTurn();
			}
		}
	}


	public void AddPlayerToTurnOrder(int turnOrder, System.Object player)
	{
		// Check that the player sub-classes from TurnEntity
		if (!player.GetType().IsSubclassOf(typeof(TurnEntity)))
		{
			Debug.Log("ERROR ADDING PLAYER");
			throw new ArgumentException(String.Format("{0} does not inherit from TurnEntity.", player), "player");
		}

		if (players.Count > 0)
		{
			// Get the entity that currently is playing out it's turn
			System.Object currentTurnEntity = players[currentTurn];

			// Insert the new entity
			players.Insert(turnOrder, player);

			// Restore the turn count to where it was before
			currentTurn = players.IndexOf(currentTurnEntity);
		}
		else
		{
			players.Insert(turnOrder, player);
		}
	}
}
