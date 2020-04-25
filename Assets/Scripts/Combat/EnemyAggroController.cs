using UnityEngine;

public class EnemyAggroController : MonoBehaviour
{
	public bool inCombat = false;
	private GameObject _player;

	// start method: get initial position

	private void Update()
	{
		if (!inCombat)
		{
			return;
		}
		if ((transform.parent.position - _player.transform.position).normalized.x < 0f)
		{
			// turn right
		}
		else
		{
			// turn left
		}

		// move transform forward
		// if v2.distance (enemy, player) close enough swing
		// if v2.distance (current enemy position, initial enemy position)
		// stop chasing, run back
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
	}
}
