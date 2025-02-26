using UnityEngine;


[System.Serializable]
public class Exit 
{
    public string keyString;
    [TextArea]
    public string exitDescription;
    public Room valueRoom;
}
