using UnityEngine;
using UnityEngine.Assertions;

public enum Direction
{
    NONE,
    LEFT,
    RIGHT
};

public class PlayerMovementController : MonoBehaviour
{
    public float speedMultiplier;
	public float jumpForce;
    public float moveForce;

    [Tooltip("Should be Impulse for now.")]
	public ForceMode2D jumpForceMode;

	private PlayerGroundChecker _groundChecker;
	private Rigidbody2D _rigidbody;
	private Vector2 _direction;
	private Vector2 _jumpVector;
    private float direction;
    Vector2 movement;
    float maxVelocity = 18;

    private Direction _playerDirection = Direction.RIGHT;

	private const string HORIZONTAL_AXIS = "Horizontal";
    private const string VERTICAL_AXIS = "Vertical";

    private void Start()
	{
		_jumpVector = new Vector2(0f, jumpForce);
		_groundChecker = transform.GetComponentInChildren<PlayerGroundChecker>();
        _rigidbody = transform.GetComponent<Rigidbody2D>();
    }

    public Direction GetPlayerDirection()
    {
        return _playerDirection;
    }

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && _groundChecker.IsGrounded)
		{
            _jumpVector.Set(0f, jumpForce);
			_rigidbody.AddForce(_jumpVector, jumpForceMode);  
		}

		if (Input.GetKey(KeyCode.K))
		{
            //FindObjectOfType<AudioManager>().PlaySound("ButtonClick");
        }

        if (Input.GetKey(KeyCode.D))
        {
            _direction.Set(moveForce, 0f);
            _rigidbody.AddForce(_direction);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _direction.Set(-moveForce, 0f);
            _rigidbody.AddForce(_direction);
        }

        direction = Input.GetAxis(HORIZONTAL_AXIS);
        movement = new Vector2(direction, _rigidbody.position.y);
    }

    private void FixedUpdate()
	{
        //transform.position += new Vector3(direction * Time.fixedDeltaTime * speedMultiplier, 0f);
        _rigidbody.velocity = new Vector2(Mathf.Clamp(_rigidbody.velocity.x, -maxVelocity, maxVelocity), _rigidbody.velocity.y);

        if (Mathf.Approximately(direction, 0.0f))
        {
            _playerDirection = Direction.NONE;
        }
        else if (direction < 0f)
        {
            _playerDirection = Direction.LEFT;
        }
        else
        {
            _playerDirection = Direction.RIGHT;
        }
    }
}
