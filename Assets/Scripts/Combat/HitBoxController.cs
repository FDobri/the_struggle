using UnityEngine;

public class HitBoxController : MonoBehaviour
{
	private const float SELF_DESTRUCT_TIMER = 0.5f;

	public string hitBoxTargetTag;

	private float _selfDestructTimer = SELF_DESTRUCT_TIMER;

    void Update()
    {
		_selfDestructTimer -= Time.deltaTime;
		if (_selfDestructTimer <= 0.0f && gameObject != null)
		{
			Destroy(gameObject);
		}
	}

	private void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag.Equals(hitBoxTargetTag))
		{
			int damage = gameObject.GetComponentInParent<Attributes>().damage;
			var collidedObjectAttributes = collider.gameObject.GetComponent<Attributes>();
			if (collidedObjectAttributes)
			{
				collidedObjectAttributes.TakeDamage(damage);
				Destroy(gameObject);
			}
		}
	}

	public void Activate()
	{
		gameObject.SetActive(true);
		_selfDestructTimer = SELF_DESTRUCT_TIMER;
	}
}
