using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LogicScriptFallingClocks : MonoBehaviour
{
    public int playerScore;
    public TMP_Text scoreText;

    [ContextMenu("Add 1 score")]
    public void addScore(int scoreToAdd = 1) {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    [ContextMenu("Remove 1 score")]
    public void removeScore(int scoreToRemove = 1, int minScore = 0) {
        
        playerScore -= scoreToRemove;
        if (playerScore < minScore) { playerScore = minScore; }
        scoreText.text = playerScore.ToString();
    }

    public int getScore() {
        return playerScore;
    }
}

