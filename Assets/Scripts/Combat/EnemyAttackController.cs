using UnityEngine;

public class EnemyAttackController : AttackController
{
	private const float MIN_DISTANCE_TO_ATTACK = 4f;
	private Transform _playerTransform;
	public EnemyAggroController enemyAggroController;

    void Start()
    {
		_playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
	}

	void Update()
    {
        if (!enemyAggroController.inCombat)
		{
			return;
		}
		if (Vector3.Distance(gameObject.transform.position, _playerTransform.position) < MIN_DISTANCE_TO_ATTACK)
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
