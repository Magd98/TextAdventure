using System;
using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    public InputField inputField;

    GameController controller;

    void Awake()
    {
        controller = GetComponent<GameController>();

        inputField.onEndEdit.AddListener(AcceptStringInput);
    }

     void AcceptStringInput(string userInput)
    {
        userInput = userInput.ToLower();
        controller.LogStringWithReturn(userInput);

        char[] delimiterCharachters = { ' ' };
        string[] seperatedInputWords = userInput.Split(delimiterCharachters);

        for (int i = 0 ; i < controller.inputActions.Length ; i++)
        {
            InputActions inputActions = controller.inputActions[i];
            if (inputActions.keyword == seperatedInputWords[0])
            {
                inputActions.RespondToInput(controller , seperatedInputWords);
            }
        }

        InputComplete();
    }
    
    void InputComplete()
    {
        controller.DisplayLoggedText();
        inputField.ActivateInputField();
        inputField.text = null;
    }
}
