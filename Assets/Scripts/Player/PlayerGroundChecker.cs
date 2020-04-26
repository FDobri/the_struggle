using UnityEngine;

public class PlayerGroundChecker : MonoBehaviour
{
	public bool IsGrounded { get; private set; }


	private void OnCollisionEnter2D(Collision2D collision)
	{
		string collisionTag = collision.transform.tag;
		CheckIfGroundedAndSetState(collisionTag, true);
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		string collisionTag = collision.transform.tag;
		CheckIfGroundedAndSetState(collisionTag, false);
	}

	private void CheckIfGroundedAndSetState(string collisionTag, bool grounded)
	{
		if (collisionTag.Equals("Ground"))
		{
			IsGrounded = grounded;
		}
	}
}
