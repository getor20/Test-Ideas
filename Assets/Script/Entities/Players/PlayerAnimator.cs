using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private PlayerMover _playerMover;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        _animator.SetFloat(PlayerAnimationParameters.directionX, _playerMover.DirectionVector.x);
        _animator.SetFloat(PlayerAnimationParameters.directionY, _playerMover.DirectionVector.y);
        _animator.SetFloat(PlayerAnimationParameters.speed, _playerMover.CurrentSpeed);

    }
}
