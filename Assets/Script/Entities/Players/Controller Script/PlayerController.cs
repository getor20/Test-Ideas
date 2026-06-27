using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerStats _playerStats;
    private PlayerMover _playerMover;
    private PlayerInputData _playerInputData;

    public bool CanMove { get; set; } = true;

    private void Awake()
    {
        _playerStats = GetComponent<PlayerStats>();
        _playerMover = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        if (!CanMove)
        {
            _playerMover.Stop();
            return;
        }

        HandleMovement();
    }

    private void HandleMovement()
    {
        if (_playerInputData.MoveDirection != Vector2.zero)
        {
            float targetSpeed = _playerInputData.IsRunning ? _playerStats.RunSpeed : _playerStats.WalkingSpeed;
            _playerMover.Move(_playerInputData.MoveDirection, targetSpeed);
        }
        else
        {
            _playerMover.Stop();
        }
    }

    internal void SetIntup(PlayerInputData playerInputData)
    {
        _playerInputData = playerInputData;
    }
}
