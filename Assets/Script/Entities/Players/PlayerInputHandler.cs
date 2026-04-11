using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] private PlayerMover _playerMover;

    public void OnMove(InputAction.CallbackContext context)
    {
        var inputVector = context.ReadValue<Vector2>();

        _playerMover.SetDirection(inputVector);

    }

    public void OnRun(InputAction.CallbackContext context)
    {
        /*if (context.started)
        {
            _playerMover.SetRunning(true);
        }
        else if (context.canceled)
        {
            _playerMover.SetRunning(false);
        }*/

        _playerMover.SetRunning(context.ReadValueAsButton());
    }
}
