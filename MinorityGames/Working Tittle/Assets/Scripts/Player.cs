using UnityEngine;
using System.Collections;

public class Player : TurnEntity {
	
	private HealthBar playerHealthScript;
	private Animator animator;
    private CharacterStats player;
	private GameObject playerButtons;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		playerHealthScript = GetComponent<HealthBar>();
        player = CharacterManager.LoadCharacterSelected();
		playerButtons = GameObject.FindGameObjectWithTag("PlayerInput");
	}
	
	// Update is called once per frame
	void Update () {
		animator.SetInteger ("AnimState", 1); // this is a test please stand by
		setPlayerHealthAvatar ("PlayerLogo","Logo_" + player.charName); // this is a test please stand by

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



	//        CALLBACKS FOR PLAYER BUTTONS         //

	public void LightAttack()
	{
		// Do your light attack stuff here

		FinishTurn();
	}

	public void HeavyAttack()
	{
		// Do your heavy attack stuff here

		FinishTurn();
	}

	public void Block()
	{
		// Do your block stuff here

		FinishTurn();
	}

	public void SpecialAttack()
	{
		// Do your special attack stuff here

		FinishTurn();
	}

	// You can add other calbacks here, you just need to make the function and a button to call the function
	// (Look at the PlayerInputScript Script)




	// Turn based stuff
	public override void TakeTurn ()
	{
		// You can decide what to do on your turn here

		// Enable the player buttons
		playerButtons.SetActive(true);
	}

	public override void TakeTurn (ArrayList allPlayersThisTurn)
	{
		// You can decide what to do on your turn here, with a list of other players (probably more useful for AI)

		// Enable the player buttons
		playerButtons.SetActive(true);
	}


	// Small little cleanup function for finishing turn (disables buttons, etc)
	private void FinishTurn()
	{
		playerButtons.SetActive(false);
		turnIsFinished = true;
	}

}
