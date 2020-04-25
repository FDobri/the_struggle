using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackController : AttackController
{
	[HideInInspector]
	public bool inCombat = false;
	private Transform _playerTransform;

    void Start()
    {
		_playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

	void Update()
    {
        if (!inCombat)
		{
			return;
		}
		if (Vector2.Distance(gameObject.transform.position, _playerTransform.position) < 3f)
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
