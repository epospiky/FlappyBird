using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class logicscript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    //[ContextMenu("Increase Score")]
    public void addScore()
    {
        Debug.Log("I just passed!");
        playerScore += 1;
        scoreText.text = playerScore.ToString();
    }
}
