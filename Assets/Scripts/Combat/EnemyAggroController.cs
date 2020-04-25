using UnityEngine;

public class EnemyAggroController : MonoBehaviour
{
	private static Vector3 vectorLeft = new Vector3(0f, 180f, 0f);
	private static Vector3 vectorRight = new Vector3(0f, 0f, 0f);

	public GameObject enemyModel;
	public EnemyMovementController enemyMovementController;

	[HideInInspector]
	public bool inCombat = false;
	private GameObject _player;
	private Vector2 _startingPosition;
	private Vector2 _targetAngle;

	private void Start()
	{
		_startingPosition = transform.position;
	}

	private void Update()
	{
		if (!inCombat || _player == null)
		{
			return;
		}

		enemyMovementController.SetDestination(_player.transform.position);
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

	public void EnterCombat()
	{
		inCombat = true;
	}

	public void ExitCombat()
	{
		inCombat = false;
		enemyMovementController.SetDestination(_startingPosition);
	}
}
