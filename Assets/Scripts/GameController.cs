using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController: MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString(); 
    }
  
    public void ReloadLevel()
    {
        SceneManager.LoadScene("Level_1");
    }
}
