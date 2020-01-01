using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class state : ScriptableObject
{
   [TextArea(14, 10)] [SerializeField] string storyText;

    [SerializeField] state[] nextStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public state[] getNextStates()
    {
        return nextStates;
    }
}
