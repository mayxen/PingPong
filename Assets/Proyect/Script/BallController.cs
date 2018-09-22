using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallController : MonoBehaviour {
    public float speed = 1f;
    public float dificulty= 1.1f;
    Rigidbody2D rb;
    public AudioSource rebote;
    

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(speed-0.5f, speed+0.5f) *(Random.value < 0.5f?-1:1), Random.Range(speed - 0.5f, speed + 0.5f) * (Random.value < 0.5f ? -1 : 1));
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Limit"))
        {
            rb.velocity = new Vector2(rb.velocity.x, -rb.velocity.y);
            rebote.Play();
        }
        else if (collision.CompareTag("Player"))
        {
            rb.velocity = new Vector2(-rb.velocity.x*dificulty, rb.velocity.y*dificulty);
            rebote.Play();
        }
        else if (collision.CompareTag("porteria1"))
        {
            Destroy(gameObject);
            GameController.instance.AddScore(2);
            
        }
        else if (collision.CompareTag("porteria2"))
        {
            Destroy(gameObject);
            GameController.instance.AddScore(1);
        }
    }
}
