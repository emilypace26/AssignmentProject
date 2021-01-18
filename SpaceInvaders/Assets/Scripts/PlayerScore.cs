using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    private float playerScore = 0;
    private Text scoreText;
    void Start()
    {
        scoreText = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + playerScore.ToString(); 
    }
    public void IncremenScoreRed()
    {
        playerScore += 6;
        Debug.Log("Increased Score by 6" + playerScore);
    }
    public void IncremenScoreBlue()
    {
        playerScore += 4;
        Debug.Log("Increase Score by 4" + playerScore);
    }
    public void IncremenScoreGreen()
    {
        playerScore += 2;
        Debug.Log("Increase Score by 2" + playerScore);
    }
}
