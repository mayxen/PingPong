using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddelController : MonoBehaviour {
    public float speed;
    public int playerIndex;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float direction= Input.GetAxis("Vertical"+playerIndex);
        if (direction != 0)
        {
            rb.velocity =  (Vector3.up * direction * speed);
            
        }
        
	}
}
