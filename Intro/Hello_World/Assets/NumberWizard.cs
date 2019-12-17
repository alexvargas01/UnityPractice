using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    int max = 1000;
    int min = 1;
    int guess = 500;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max=1000;
        min=1;
        guess=500;

        Debug.Log("----------Welcome to Number Wizard!----------");
        Debug.Log("Pick a number");
        Debug.Log("The Highest number is: " + max);
        Debug.Log("The Lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("**********Push up = Higher, Push Down = Lower, Push Enter = Correct**********");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("----------I am a genius!----------");
            StartGame();
        }

    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than " + guess);
    }
}