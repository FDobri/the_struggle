using UnityEngine;

public class PlayerGroundChecker : MonoBehaviour
{
	public bool IsGrounded{ get; private set; }

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.tag.Equals("Ground"))
		{
			IsGrounded = true;
		}
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		string collisionTag = collision.transform.tag;
		if (collisionTag.Equals("Ground") || collisionTag.Equals("Enemy"))
		{
			IsGrounded = false;
		}
	}
}
