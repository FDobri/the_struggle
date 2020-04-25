using UnityEngine;

public class AttackController : MonoBehaviour
{
	private const float DAMAGE_HIT_BOX_DISTANCE = 2f;
	private const float STANDARD_COOLDOWN = 3f;

	public float attackCooldown = STANDARD_COOLDOWN;
	public GameObject hitBox;

	[HideInInspector]
	public bool canAttack = true;

	public void Attack()
	{
		if (canAttack)
		{
			Debug.Log(transform.name + " attacked!");
			HitBoxController hitBoxController = hitBox.GetComponent<HitBoxController>();
			hitBoxController.Activate();
			//Play character animation (transition into)
			attackCooldown = STANDARD_COOLDOWN;
			canAttack = false;
		}
	}
}
