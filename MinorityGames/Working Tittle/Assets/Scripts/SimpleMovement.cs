using UnityEngine;
using System.Collections;

public class SimpleMovement : MonoBehaviour {
    public float speed = 5f;
    private Rigidbody2D body2D;

	// Use this for initialization
	void Start () {
        body2D = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {
        var val = Input.GetAxis("Horizontal");
        body2D.velocity = new Vector2(speed * val, body2D.velocity.y);

	
	}
}
