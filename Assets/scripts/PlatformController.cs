using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {

    public float speed = 1; 
    private Rigidbody2D myrigidbody2D;
	// Use this for initialization
	void Start () {

        myrigidbody2D = GetComponent<Rigidbody2D>(); 
	}
	
	// Update is called once per frame
	void Update () {
        var move = new Vector2(Input.GetAxis("Horizontal"),0);
        //myrigidbody2D.velocity += move * speed; acceleration 
        myrigidbody2D.velocity = new Vector2(move.x * speed, myrigidbody2D.velocity.y);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            myrigidbody2D.velocity += new Vector2(0, 5);
        }
    }
}
