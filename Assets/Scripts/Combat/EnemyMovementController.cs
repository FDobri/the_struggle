using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
	private const float MIN_DISTANCE = 3f;
	private Vector3 right = Vector3.up;
	private Vector3 left = Vector3.up * -180f;

	public Transform model;
	public float movementSpeed = 10f;

	private Vector3 _destination;
	private float _direction;
	private bool _hasDestination;
	private float _timeOnJourney = 0f;
	private float _timeThreshold = 10f;

	public void SetDestination(Vector3 destination)
	{
		if (Vector3.Distance(destination, transform.position) < MIN_DISTANCE)
		{
			return;
		}
		_timeOnJourney = 0f;
		_destination = destination;
		_hasDestination = true;		

		_direction = destination.x - transform.position.x;
		if (_direction > 0f)
		{
			transform.eulerAngles = Vector3.up;
		}
		else
		{
			transform.eulerAngles = left;
		}
	}

	public bool HasDestination()
	{
		return _hasDestination;
	}

	private void Update()
	{
		if (!_hasDestination)
		{
			return;
		}

		_timeOnJourney += Time.deltaTime;

		transform.position += transform.right * Time.fixedDeltaTime * movementSpeed;

		//transform.position += model.right * Time.deltaTime * movementSpeed;
		if (Vector2.Distance(model.position, _destination) < 3f || _timeOnJourney > _timeThreshold)
		{
			_hasDestination = false;
		}
	}
}
