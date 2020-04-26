using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
	public float speedMultiplier;
	public float jumpForce;
	public float moveForce;

	public Animator characterAnimator;

	[Tooltip("Should be Impulse for now.")]
	public ForceMode2D jumpForceMode;

	private PlayerGroundChecker _groundChecker;
	private Rigidbody2D _rigidbody;
	private float _direction;
	private Vector2 _jumpVector;
	private float _movementSpeed = 0f;

	Vector2 previousPosition;

	private const string HORIZONTAL_AXIS = "Horizontal";

	private void Start()
	{
		previousPosition = gameObject.transform.position;

		_jumpVector = new Vector3(0f, jumpForce);
		_groundChecker = transform.GetComponentInChildren<PlayerGroundChecker>();
		_rigidbody = transform.GetComponent<Rigidbody2D>();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && _groundChecker.IsGrounded)
		{
			_jumpVector.Set(0f, jumpForce);
			_rigidbody.AddForce(_jumpVector, jumpForceMode);
		}
	}

	private void FixedUpdate()
	{
		Vector3 currentPosition = transform.position;
		_movementSpeed = Vector3.Distance(currentPosition, previousPosition);
		previousPosition = currentPosition;
		characterAnimator.SetFloat("movementSpeed", _movementSpeed);

		_direction = Input.GetAxis(HORIZONTAL_AXIS);

		if (_direction > 0f)
		{
			transform.eulerAngles = Vector3.up;
		}
		else if (_direction < 0f)
		{
			transform.eulerAngles = Vector3.up * -180f;
		}

		transform.position += new Vector3(_direction * Time.fixedDeltaTime * speedMultiplier, 0f);
	}
}
