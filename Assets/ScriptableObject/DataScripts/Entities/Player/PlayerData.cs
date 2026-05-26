using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStatBlock", menuName = "StatBlock/Player Stat Block", order = -1000)]
public class PlayerData : ScriptableObject
{
    public int HP;
    public int Stamina;
    public int WalkingSpeed;
    public int RunSpeed;
    public int SlowSpeed;
}