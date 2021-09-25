using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] private Text textComponent;
    [SerializeField] private State startingState;

    private State state;

    // Start is called before the first frame update
    private void Start()
    {
        state = startingState;
        textComponent.text = state.getStoryText();
    }

    // Update is called once per frame
    private void Update()
    {

    }
}
