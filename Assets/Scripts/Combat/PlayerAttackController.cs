using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackController : AttackController
{
	private void Update()
	{
		if (Input.GetMouseButtonUp(0))
		{
			Attack();
		}

		if (!canAttack)
		{
			attackCooldown -= Time.deltaTime;
			if (attackCooldown <= 0.0f)
			{
				canAttack = true;
			}
		}

	}
}
