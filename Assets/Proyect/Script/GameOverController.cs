using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour {
    public Text line;
	public void Play()
    {
        SceneManager.LoadScene("Start");
    }

    private void Start()
    {
        if (GameController.instance.player1Score > GameController.instance.player2Score)
            line.text = "Player 1 WON!";
        else
            line.text = "Player 2 WON!";
        Destroy(GameController.instance.gameObject);
    }
}
