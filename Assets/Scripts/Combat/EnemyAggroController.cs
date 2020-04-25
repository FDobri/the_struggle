using UnityEngine;

public class EnemyAggroController : MonoBehaviour
{
	private static Vector3 vectorLeft = new Vector3(0f, 180f, 0f);
	private static Vector3 vectorRight = new Vector3(0f, 0f, 0f);

	public float speedMultiplier;
	public GameObject enemyModel;

	private float _singleStep = 0f;
	[HideInInspector]
	public bool inCombat = false;
	private GameObject _player;
	private Vector2 _startingPosition;
	private Vector2 _targetAngle;

	int testCounter = 0;

	// start method: get initial position

	private void Start()
	{
		_startingPosition = transform.position;
	}

	private void Update()
	{
		if (!inCombat)
		{
			return;
		}



		//Vector3 currentAngle = enemyModel.transform.eulerAngles;
		//Vector3 targetAngle;

		//_singleStep = 20f * Time.deltaTime;

		//float direction = (transform.parent.position - _player.transform.position).normalized.x;
		//if (direction > 0f)
		//{
		//	targetAngle = vectorLeft;
		//}
		//else
		//{
		//	targetAngle = vectorRight;
		//}

		//currentAngle = new Vector3(
		//	 Mathf.LerpAngle(currentAngle.x, targetAngle.x, _singleStep),
		//	 Mathf.LerpAngle(-currentAngle.y, targetAngle.y, _singleStep),
		//	 Mathf.LerpAngle(currentAngle.z, targetAngle.z, _singleStep)
		//	 );

		//enemyModel.transform.eulerAngles = currentAngle;

		//// move transform right
		//transform.position += new Vector3(direction * Time.fixedDeltaTime * speedMultiplier, 0f);

		////if v2.distance (enemy, player) close enough swing

		//// if v2.distance (current enemy position, initial enemy position)
		//if (Vector2.Distance(transform.position, _startingPosition) > 14f)
		//{
		//	// stop chasing, run back
		//	targetAngle = -targetAngle;
		//}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag.Equals("Player"))
		{
			EnterCombat();
			_player = collision.gameObject;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.tag.Equals("Player") && inCombat)
		{
			ExitCombat();
		}
	}

	private void _SetDestination(Vector2 point)
	{
		//_destination = point;
	}

	public void EnterCombat()
	{
		inCombat = true;
	}

	public void ExitCombat()
	{
		inCombat = false;
	}
}
