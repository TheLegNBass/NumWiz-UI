using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    private int guess;
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guessText;

    // Start is called before the first frame update
    void Start()
    {
        NextGuess();
    }

    public void OnHigherPress()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnLowerPress()
    {
        max = guess - 1;
        NextGuess();
    }

    public void NextGuess()
    {
        guess = UnityEngine.Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
