using System.Collections.Generic;
using UnityEngine;

public class RoomNavigation : MonoBehaviour
{
    public Room currentRoom;
    GameController controller;

    Dictionary<string , Room> exitDictionary = new Dictionary<string , Room>();

    private void Awake()
    {
        controller = GetComponent<GameController>();
    }

    public void UnpackExitsInRoom()
    {
        for (int i = 0 ; i < currentRoom.exits.Length ; i++)
        {
            exitDictionary.Add(currentRoom.exits[i].keyString , currentRoom.exits[i].valueRoom);
            controller.interactionDescriptionInRoom.Add(currentRoom.exits[i].exitDescription);
        }
    }

    public void AttemptToChangeRooms(string directionNoun)
    {
        if (exitDictionary.ContainsKey(directionNoun))
        {
            currentRoom = exitDictionary[directionNoun];
            controller.LogStringWithReturn("You headed off to " + directionNoun);
            controller.DisplayText();
        }
        else
        {
            controller.LogStringWithReturn("There is no path to the " + directionNoun);
        }
    }

    public void ClearExits()
    {
        exitDictionary.Clear();
    }
}
    
