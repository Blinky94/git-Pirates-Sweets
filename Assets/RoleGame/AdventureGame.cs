using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State StartingState;
    State state;

    string fileName = "state1.txt";

    // Start is called before the first frame update
    void Start()
    {
      state =  StartingState;
      textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
