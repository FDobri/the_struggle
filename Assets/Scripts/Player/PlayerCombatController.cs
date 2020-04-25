using UnityEngine;

public class PlayerCombatController : MonoBehaviour
{
	private const float ATTACK_COOLDOWN = 0.5f;
	private const float DAMAGE_HIT_BOX_DISTANCE = 2f;

	public GameObject damageBox;
	public GameObject playerModel;

	private float _attackCooldown = ATTACK_COOLDOWN;
	private bool canAttack = true;

	public void Attack()
	{
		if (canAttack)
		{
			GameObject hitBox = Instantiate(damageBox, playerModel.transform.position + (playerModel.transform.right * DAMAGE_HIT_BOX_DISTANCE), Quaternion.identity);
			//Play character animation (transition into)
			_attackCooldown = ATTACK_COOLDOWN;
			canAttack = false;
		}
	}

	private void Update()
	{
		if (Input.GetMouseButton(0))
		{
			Attack();
		}
		if (!canAttack)
		{
			_attackCooldown -= Time.deltaTime;
			if (_attackCooldown <= 0.0f)
			{
				canAttack = true;
			}
		}
	}
}
