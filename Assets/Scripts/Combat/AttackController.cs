using UnityEngine;

public class AttackController : MonoBehaviour
{
	private const float DAMAGE_HIT_BOX_DISTANCE = 2f;
	private const float STANDARD_COOLDOWN = 3f;

	public float attackCooldown = STANDARD_COOLDOWN;
	public GameObject hitBoxLocation;
	public GameObject hitBoxPrefab;
	public Animator animator;

	[HideInInspector]
	public bool canAttack = true;

	public void Attack()
	{
		if (canAttack)
		{
			if (animator != null)
			{
				if (Random.Range(0, 9) % 2 == 0)
				{
					animator.SetTrigger("attack01");
				}
				else
				{
					animator.SetTrigger("attack02");
				}
			}
			Debug.Log(transform.name + " attacked!");
			GameObject hitBox = Instantiate(hitBoxPrefab, hitBoxLocation.transform);
			hitBox.GetComponent<HitBoxController>().Activate();
			attackCooldown = STANDARD_COOLDOWN;
			canAttack = false;
		}
	}
}
