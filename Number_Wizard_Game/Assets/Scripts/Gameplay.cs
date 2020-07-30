using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guessText;
    int guess;
    
    void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        Calculation();
    }
    public void OnPressHigher()
    {
        min = guess;
        Calculation();
    }

    public void OnPressLower()
    {
        max = guess;
        Calculation();
    }

    private void Calculation()
    {
        guess = Random.Range(min, max+1);
        guessText.text = guess.ToString();
    }

    public void Exit()
    {
        Application.Quit();
    }
}
