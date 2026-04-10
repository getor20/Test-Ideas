using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private Rigidbody2D _rigidBody;

    private Vector2 _direction;

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

    private void Muve()
    {
        _rigidBody.linearVelocity = _direction * _speed;
    }
}
