using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour 
{
    // global editor in Unity
    [SerializeField] Text text;
    [SerializeField] SO_State startingState;
   

    // Visual Studio Global
    SO_State state;
    string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };    

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        text.text = state.GetStateStory();
        for (int i = 0; i < daysOfTheWeek.Length; i++)
        {
            Debug.Log(daysOfTheWeek[i]);
        } ;
       
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        throw new NotImplementedException();
    }
}
