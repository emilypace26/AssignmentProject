using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Update(){
        if(Input.GetKeyDown(KeyCode.R)){
        PlayerScore.playerScore = 0;
        GameOver.isPlayerDead = false;
        Time.timeScale = 1;

        SceneManager.LoadScene("SpaceInvaders");

    }
        
    }
}
