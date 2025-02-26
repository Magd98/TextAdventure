using UnityEngine;

public class RoomNavigation : MonoBehaviour
{
    public Room currentRoom;
    GameController controller;

    private void Awake()
    {
        controller = GetComponent<GameController>();
    }

    public void UnpackExitsInRoom()
    {
        for (int i = 0 ; i < currentRoom.exits.Length ; i++)
        {
            controller.interactionDescriptionInRoom.Add(currentRoom.exits[i].exitDescription);
        }
    }
}
    
