using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// make it accesible to Asset Menu
[CreateAssetMenu(menuName = "SO_State")]
public class SO_State : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] string StoryText;
    [SerializeField] SO_State[] nextStates;

    public string GetStateStory()
    {
        

        return StoryText;
    }

    public SO_State[] GetNextStates()
    {
        return nextStates;

    }
}


