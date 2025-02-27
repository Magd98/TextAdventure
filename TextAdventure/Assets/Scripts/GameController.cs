using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [HideInInspector] public RoomNavigation roomNavigation;
    [HideInInspector] public List<string> interactionDescriptionInRoom = new List<string>();

    public InputActions[] inputActions;

    public Text displayText;

    List<string> actionLog = new List<string>();
    void Awake()
    {
        roomNavigation = GetComponent<RoomNavigation>();
    }

    void Start()
    {
        DisplayText();
        DisplayLoggedText();
    }
    public void DisplayText()
    {
        ClearCollectionsForNewRooms();

        UnpackRoom();

        string joinedInteractionDescriptions = string.Join("\n" , interactionDescriptionInRoom.ToArray());

        string combinedText = roomNavigation.currentRoom.description + "\n" + joinedInteractionDescriptions;

        LogStringWithReturn(combinedText);
    }

    public void LogStringWithReturn(string actionToAdd)
    {
        actionLog.Add(actionToAdd + "\n");
    }

    public void DisplayLoggedText()
    {
        string logAsText = string.Join("\n" , actionLog.ToArray());
        displayText.text = logAsText;
    }
    public void UnpackRoom()
    {
        roomNavigation.UnpackExitsInRoom();
    }

    void ClearCollectionsForNewRooms()
    {
        interactionDescriptionInRoom.Clear();
        roomNavigation.ClearExits();
    }
}
