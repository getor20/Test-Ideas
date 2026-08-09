using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStatBlock", menuName = "StatBlock/Player Stat Block", order = -1000)]
public class PlayerData : ScriptableObject
{
    public float HP;
    public float Stamina;
    public float WalkingSpeed;
    public float RunSpeed;
    public float SlowSpeed;
}