using UnityEngine;
using System.Collections;

public class UserInputHandler : MonoBehaviour {

    public float speed = 5f;
    private Rigidbody2D body2D;
    //Holds a refernce to a method
    public delegate void TapAction(Touch t);

    /*
     * message sent to other object, 
     * get sent to any scripts that register to the event
     */ 
    public static event TapAction OnTap;
    public float tapMaxMovement = 50f; //max amount a touch can move in pixel to  still be still considered a tap
    private Vector2 movement; // keeping how far we have moved
    private bool tapGestureFailed = false; // set to true if user move their finger too far

	// Use this for initialization
	void Start () {
        body2D = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
        {
            // array of all the touches on the screen, can loop through for handling mutiple touches
            Touch touch = Input.touches[0]; 

            /*
             * Touches have diffrent phases: Began, Moved, Stationary, Ended, Cancelled
             */
            if (touch.phase == TouchPhase.Began)
            {
                movement = Vector2.zero;
            }
            else if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                movement += touch.deltaPosition;

                Vector2 touchPosition = Input.GetTouch(0).position;
                double halfScreen = Screen.width / 2.0;

                //check if it is left or right?
                if (touchPosition.x < halfScreen)
                {
                    body2D.transform.Translate(Vector3.left * 5 * Time.deltaTime);
                }
                else if (touchPosition.x > halfScreen)
                {
                    body2D.transform.Translate(Vector3.right * 5 * Time.deltaTime);
                    //body2D.velocity = new Vector2(speed * val, body2D.velocity.y);
                }
                Debug.Log("Tapped");
                if (movement.magnitude > tapMaxMovement)
                    tapGestureFailed = true;
            }
            else
            {
                if (!tapGestureFailed)
                {
                    if (OnTap != null)
                        OnTap(touch);
                    Debug.Log("!Tapped");
                }
                tapGestureFailed = false;
            }
        }
	
	}
}
