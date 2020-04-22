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
		if (collision.transform.tag.Equals("Ground"))
		{
			IsGrounded = false;
		}
	}
}
