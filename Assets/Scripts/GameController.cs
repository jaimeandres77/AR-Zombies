using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    float currScore = 0;

    [SerializeField] Text scoreAmount;
    void Start()
    {
        currScore = 0;
        UpdateScoreUI();
    }
    
    public void AddScore(float amount)
    {
        currScore += amount;
        UpdateScoreUI();
    }

    private void UpdateScoreUI() 
    {
        scoreAmount.text = currScore.ToString("0");
    }
}
