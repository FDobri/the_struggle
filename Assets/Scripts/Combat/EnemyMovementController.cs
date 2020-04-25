using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
	public Transform model;
	public float movementSpeed = 10f;

	private Vector2 _destination;
	private bool hasDestination;
	private float _timeOnJourney = 0f;
	private float _timeThreshold = 10f;

	public void SetDestination(Vector2 destination)
	{
		_timeOnJourney = 0f;
		_destination = destination;
		hasDestination = true;
		model.LookAt(destination);
	}

	private void Update()
	{
		if (!hasDestination)
		{
			return;
		}

		_timeOnJourney += Time.deltaTime;
		model.position += model.right * Time.deltaTime * movementSpeed;
		if (Vector2.Distance(model.position, _destination) < .5f || _timeOnJourney > _timeThreshold)
		{
			hasDestination = false;
		}
	}
}
