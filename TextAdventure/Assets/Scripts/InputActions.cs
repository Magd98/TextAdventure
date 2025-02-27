using UnityEngine;

public abstract class InputActions : ScriptableObject
{
    public string keyword;
    public abstract void RespondToInput(GameController controller , string[] seperatedInputWords);
}
