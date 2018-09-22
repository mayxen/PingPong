using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
    public Text player1Text;
    public Text player2Text;
    // Use this for initialization
    
	
	// Update is called once per frame
	void Update () {
        player1Text.text = GameController.instance.player1Score + "";
        player2Text.text = GameController.instance.player2Score + "";
    }
}
