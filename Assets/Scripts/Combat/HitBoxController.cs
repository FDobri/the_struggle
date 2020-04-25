using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxController : MonoBehaviour
{
	private float _selfDestroyTimer = 0.5f;

    void Update()
    {
		_selfDestroyTimer -= Time.deltaTime;
		if (_selfDestroyTimer <= 0.0f && gameObject != null)
		{
			Destroy(gameObject);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log("Entered collision. Collided with: " + collision.gameObject.name);
	}
}
