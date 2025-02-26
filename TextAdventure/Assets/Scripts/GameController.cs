using UnityEngine;

public class GameController : MonoBehaviour
{
    [HideInInspector] public RoomNavigation roomNavigation;
    void Awake()
    {
        roomNavigation = GetComponent<RoomNavigation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayText()
    {
        string combinedText = roomNavigation.currentRoom.description + "/n";
    }
}
