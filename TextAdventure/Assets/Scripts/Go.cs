using UnityEngine;

[CreateAssetMenu(menuName ="TextAdventure/InputActions/Go")]
public class Go : InputActions
{
    public override void RespondToInput(GameController controller , string[] seperatedInputWords)
    {
        controller.roomNavigation.AttemptToChangeRooms(seperatedInputWords[1]);
    }
}
