
using UnityEngine;

[CreateAssetMenu(fileName ="Data", menuName = "ScriptableObjects/Data")]

public class DataOS : ScriptableObject
{
    public int levelUnlocked = 1;
    public bool boxMoving = false;
    public bool cakeMoving = false;

}
