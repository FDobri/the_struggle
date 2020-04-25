using UnityEngine;

public class HitBoxController : MonoBehaviour
{
	private const float SELF_HIDE_TIMER = 0.5f;

	public string hitBoxTargetTag;

	private float _selfHideTimer = SELF_HIDE_TIMER;

    void Update()
    {
		_selfHideTimer -= Time.deltaTime;
		if (_selfHideTimer <= 0.0f && gameObject != null)
		{
			gameObject.SetActive(false);
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
				gameObject.SetActive(false);
			}
		}
	}

	public void Activate()
	{
		gameObject.SetActive(true);
		_selfHideTimer = SELF_HIDE_TIMER;
	}
}
