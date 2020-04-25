using UnityEngine;

public class EnemyAggroController : MonoBehaviour
{
	public bool inCombat = false;

	private void Update()
	{
		if (!inCombat)
		{
			return;
		}


	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag.Equals("Player"))
		{
			EnterCombat();
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
