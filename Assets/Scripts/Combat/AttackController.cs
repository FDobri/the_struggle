using UnityEngine;

public class AttackController : MonoBehaviour
{
	private const float DAMAGE_HIT_BOX_DISTANCE = 2f;
	private const float STANDARD_COOLDOWN = 3f;

	public float attackCooldown = STANDARD_COOLDOWN;
	public GameObject hitBox;

	[HideInInspector]
	public bool canAttack = true;

	private Animator _animator;

	private void Start()
	{
		_animator = gameObject.GetComponentInChildren<Animator>();
	}

	public void Attack()
	{
		if (canAttack)
		{
			if (Random.Range(0,9) % 2 == 0)
			{
				_animator.SetTrigger("attack01");
			}
			else
			{
				_animator.SetTrigger("attack02");
			}
			Debug.Log(transform.name + " attacked!");
			HitBoxController hitBoxController = hitBox.GetComponent<HitBoxController>();
			hitBoxController.Activate();
			//Play character animation (transition into)
			attackCooldown = STANDARD_COOLDOWN;
			canAttack = false;
		}
	}
}
