using UnityEngine;

public class AttackController : MonoBehaviour
{
	private const float ATTACK_COOLDOWN = 0.5f;
	private const float DAMAGE_HIT_BOX_DISTANCE = 2f;

	public GameObject hitBox;

	[HideInInspector]
	public float attackCooldown = ATTACK_COOLDOWN;
	[HideInInspector]
	public bool canAttack = true;

	public void Attack()
	{
		if (canAttack)
		{
			HitBoxController hitBoxController = hitBox.GetComponent<HitBoxController>();
			hitBoxController.Activate();
			//Play character animation (transition into)
			attackCooldown = ATTACK_COOLDOWN;
			canAttack = false;
		}
	}
}
