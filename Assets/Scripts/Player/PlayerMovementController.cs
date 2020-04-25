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

    Animator plejer;

    [Tooltip("Should be Impulse for now.")]
	public ForceMode2D jumpForceMode;

	private PlayerGroundChecker _groundChecker;
	private Rigidbody2D _rigidbody;
	private Vector2 _direction;
	private Vector2 _jumpVector;
    
    private Direction _playerDirection = Direction.RIGHT;

	private const string HORIZONTAL_AXIS = "Horizontal";

	private void Start()
	{
		_jumpVector = new Vector2(0f, jumpForce);
		_groundChecker = transform.GetComponentInChildren<PlayerGroundChecker>();
        _rigidbody = transform.GetComponent<Rigidbody2D>();
        plejer = GameObject.FindWithTag("Player").GetComponent<Animator>();
    }

    public Direction GetPlayerDirection()
    {
        return _playerDirection;
    }

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && _groundChecker.IsGrounded)
		{
            plejer.SetTrigger("jumpT");
            _jumpVector.Set(0f, jumpForce);
			_rigidbody.AddForce(_jumpVector, jumpForceMode);
		}

		if (Input.GetKey(KeyCode.K))
		{
            //FindObjectOfType<AudioManager>().PlaySound("ButtonClick");
        }

    }

	private void FixedUpdate()
	{
		float direction = Input.GetAxis(HORIZONTAL_AXIS);
        
		transform.position += new Vector3(direction * Time.fixedDeltaTime * speedMultiplier, 0f);


        if (Mathf.Approximately(direction, 0.0f))
        {
            _playerDirection = Direction.NONE;
            plejer.Play("_Main_Char_Idle");
        }
        else if (direction < 0f)
        {
            _playerDirection = Direction.LEFT;
            plejer.Play("_Main_Char_Run");
        }
        else
        {
            _playerDirection = Direction.RIGHT;
            plejer.Play("_Main_Char_Run");
        }
    }
}
