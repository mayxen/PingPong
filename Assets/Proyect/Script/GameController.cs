using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    
    public GameObject ballPrefab;
    public int FinJuego = 10;
    public static GameController instance = null;
    BallController currentBall;
    public int player1Score = 0;
    public int player2Score = 0;
    public bool gameOver;
    // Use this for initialization
    void Awake () {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(this);
        
	}

    private void Start()
    {
        
        Restart();
        
    }

    void Restart()
    {
        
        GameObject ballInstance = Instantiate(ballPrefab, transform);
        currentBall = ballInstance.GetComponent<BallController>();
        currentBall.transform.position = Vector3.zero;
    }
    
    public void AddScore(int jugador)
    {
        if (jugador == 1)
            player1Score++;
        else
            player2Score++;
        if (player1Score >= FinJuego || player2Score >= FinJuego)
        {
            SceneManager.LoadScene("GameOver");
        }
        Restart();
        Restart();
    }
}
