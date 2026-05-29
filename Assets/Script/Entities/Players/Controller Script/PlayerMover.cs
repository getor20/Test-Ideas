using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _walkSpeed = 5f;
    [SerializeField] private float _runSpeed = 8f;

    [SerializeField] private float _timerDelay;

    private Rigidbody2D _rigidBody;

    private Vector2 _mainDirection;
    private Vector2 _angularVector = Vector2.zero;

    private float _timer;

    public Vector2 DirectionVector { get; private set; }



    public float CurrentSpeed => _rigidBody.linearVelocity.magnitude;

    private bool _isRunning;
    private bool _isMuving;
    //public Vector2 CurrentDirection => _direction;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Muve();
        UpdateDirectionVector();
    }

    private void UpdateDirectionVector()
    {
        if (CurrentSpeed > 0)
        {
            //  движение по прямой
            bool isDirect = Mathf.Approximately(_mainDirection.x, 0) || Mathf.Approximately(_mainDirection.y, 0);

            //  движение по угловым
            bool isAngular = _angularVector != Vector2.zero;

            if (isDirect)
            {
                if (isAngular)
                {
                    // Переход с углового на прямое. Запуск таймер.
                    _timer += Time.fixedDeltaTime;
                    if (_timer >= _timerDelay)
                    {
                        // переход
                        DirectionVector = _mainDirection;
                        _angularVector = Vector2.zero;
                        _timer = 0; // Обнуляем таймер
                    }
                }
                else
                {
                    // Движение по прямой
                    _timer = 0;
                    DirectionVector = _mainDirection;
                    _angularVector = Vector2.zero;
                }
            }
            else
            {
                // Движение по диагонали
                _timer = 0; // Обнуляем таймер
                DirectionVector = _mainDirection;
                _angularVector = _mainDirection;
            }


        }
    }

    public void SetDirection(Vector2 direction)
    {
        if (direction == Vector2.zero)
        {
            _isMuving = false;
        }
        else
        {
            _mainDirection = direction;
            _isMuving = true;
        }

    }

    public void SetRunning(bool isRunning)
    {
        _isRunning = isRunning;
    }

    private void Muve()
    {
        if (!_isMuving)
        {
            _rigidBody.linearVelocity = Vector2.zero;
            return;
        }

        float speed = _isRunning ? _runSpeed : _walkSpeed;
        _rigidBody.linearVelocity = _mainDirection * speed;
    }
}
