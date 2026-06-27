using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private PlayerScriptData _playerData;

    public float HP { get; private set; }
    public float Stamina { get; private set; }
    public float WalkingSpeed { get; private set; }
    public float RunSpeed { get; private set; }
    public float SlowSpeed { get; private set; }

    private void Awake()
    {
        Initialization();
    }

    private void Initialization()
    {
        HP = _playerData.HP;
        Stamina = _playerData.Stamina;
        WalkingSpeed = _playerData.WalkingSpeed;
        RunSpeed = _playerData.RunSpeed;
        SlowSpeed = _playerData.SlowSpeed;
    }
}
