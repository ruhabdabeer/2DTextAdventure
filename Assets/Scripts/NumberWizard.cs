using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private const int V = 1;
    int maxnumber = 1000;
    int minnumber = 1;
    int guess = 500;
  
    



    // Start is called before the first frame update
    private void Start()
    {






        // the game messages
        Debug.Log("Welcome to the number wizard !! Sup man!");
        Debug.Log("Pick a number, don't tell me what it is .... but i think your number " + guess);
        Debug.Log("The max number is : " + maxnumber);
        Debug.Log("The min number is : " + minnumber);
        maxnumber = maxnumber + 1;







    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("No you are too low");
            Debug.Log("You pressed Up !");
            minnumber = guess;
            UpdateGuess();

        }


        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Too high , guess lower plz");
            minnumber = guess;
            Debug.Log(minnumber);
            guess = (maxnumber + minnumber) / 2;
            Debug.Log("Is it " + guess);

        }
        else if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("You pressed Enter I said Enter Baraka!");

        else if (Input.GetKeyDown(KeyCode.KeypadEnter))
            Debug.Log("You pressed Enter I said Enter Baraka!");

        else if (Input.GetKeyDown(KeyCode.F))

            Debug.Log("You just fired a fuppin flippin shot");

        //else Debug.Log("Please press either up or down or enter or f");
        if (guess == 1 || (minnumber == maxnumber) || guess == 1000)
        {
            ResetGuess();
        }

    }

    private void UpdateGuess()
    {
        guess = (maxnumber + minnumber) / 2;
        Debug.Log("Is it " + guess);
    }

    private void ResetGuess()
    {       
        guess = 500;
        minnumber = 1;
        maxnumber = 1000;
        maxnumber = maxnumber + 1;
    }   

}
