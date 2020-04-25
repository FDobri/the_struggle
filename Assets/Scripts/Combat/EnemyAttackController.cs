using UnityEngine;

public class EnemyAttackController : AttackController
{
	private Transform _playerTransform;
	private EnemyAggroController _enemyAggroController;

    void Start()
    {
		_playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
		_enemyAggroController = transform.GetComponentInChildren<EnemyAggroController>();
	}

	void Update()
    {
        if (!_enemyAggroController.inCombat)
		{
			return;
		}
		if (Vector3.Distance(gameObject.transform.position, _playerTransform.position) < 3f)
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
