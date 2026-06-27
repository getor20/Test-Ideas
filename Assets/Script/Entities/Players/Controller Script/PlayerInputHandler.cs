using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerController _playerController;
    private PlayerInputData _playerInputData;

    private void Awake()
    {
        _playerController = GetComponent<PlayerController>();
    }

    private void Update()
    {
        _playerController.SetIntup(_playerInputData);

        _playerInputData.Atacking = false;
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        _playerInputData.MoveDirection = context.ReadValue<Vector2>();
    }

    public void OnRun(InputAction.CallbackContext context)
    {
        _playerInputData.IsRunning = context.ReadValueAsButton();
    }
}
