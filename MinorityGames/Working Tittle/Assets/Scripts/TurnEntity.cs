using UnityEngine;
using System.Collections;

/*
 * author: Matt Mayer
 * date: 06/05/16
 * 
 * Small abstract class representing an Entity that can take a turn during a battle.
 * This will include player controlled characters as well as any AI-controlled ones.
*/

public abstract class TurnEntity : MonoBehaviour
{
	protected ArrayList allPlayers;
	protected bool turnIsFinished;

	void Start ()
	{
		turnIsFinished = false;
	}

	public bool FinishedTurn()
	{
		return turnIsFinished;
	}

	public void ResetTurn()
	{
		turnIsFinished = false;
	}



	//             Abstract methods               //

	// You can decide what to do on your turn here
	abstract public void TakeTurn();
	// You can decide what to do on your turn here, with a list of other players (probably more useful for AI)
	abstract public void TakeTurn(ArrayList allPlayersThisTurn);
}