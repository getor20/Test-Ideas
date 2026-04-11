using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _walkSpeed = 5f;
    [SerializeField] private float _runSpeed = 8f;

    private Rigidbody2D _rigidBody;

    private Vector2 _direction;

    private bool _isRunning;

    public Vector2 CurrentSpeed => _direction;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Muve();
    }

    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
    }

    public void SetRunning(bool isRunning)
    {
        _isRunning = isRunning;
    }

    private void Muve()
    {
        float speed = _isRunning ? _runSpeed : _walkSpeed;
        _rigidBody.linearVelocity = _direction * speed;
    }
}
