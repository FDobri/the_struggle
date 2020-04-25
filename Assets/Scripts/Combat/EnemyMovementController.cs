using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
	private const float MIN_DISTANCE = 3f;

	public Transform model;
	public float movementSpeed = 10f;

	private Vector3 _destination;
	private bool hasDestination;
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
		hasDestination = true;
		model.right = destination - transform.position;
	}

	private void Update()
	{
		if (!hasDestination)
		{
			return;
		}

		_timeOnJourney += Time.deltaTime;
		transform.position += model.right * Time.deltaTime * movementSpeed;
		if (Vector2.Distance(model.position, _destination) < 3f || _timeOnJourney > _timeThreshold)
		{
			hasDestination = false;
		}
	}
}
