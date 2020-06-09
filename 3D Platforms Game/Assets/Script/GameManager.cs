using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int currentScore;
    public Text scoreText;

    public GameObject completeLevelUI;

    public void CompleteGame()
    {
        completeLevelUI.SetActive(true);
    }

    public void AddScore(int coinToAdd)
    {
        currentScore += coinToAdd;
        scoreText.text = "Score: " + currentScore + "!";
    }

}
