using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicalScript : MonoBehaviour
{
   public int playerScore = 0;
   public Text scoreText;
   public GameObject GameOverScreen;
   
   [ContextMenu("Increase Score")] 
   public void addScore(int scoreToAdd){
    playerScore += scoreToAdd;
    scoreText.text = playerScore.ToString();
   }
   public void restartGame(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
   public void gameOver(){
    GameOverScreen.SetActive(true);

   }
}
