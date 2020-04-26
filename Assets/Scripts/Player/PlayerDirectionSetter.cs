using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class PlayerDirectionSetter : MonoBehaviour
{
	public float RotationSpeed = 20.0f;
	public PlayerMovementController playerMovementController;
	private float _singleStep = 0f;
	private static Vector3 vectorLeft = new Vector3(0f, 180f, 0f);
	private static Vector3 vectorRight = new Vector3(0f, 0f, 0f);

	void Update()
	{
		//Direction _playerDirection = playerMovementController.GetPlayerDirection();

		//Vector3 currentAngle = transform.eulerAngles;
		//Vector3 targetAngle;

		//_singleStep = RotationSpeed * Time.deltaTime;
		//switch (_playerDirection)
		//{
		//	case Direction.LEFT:
		//		{
		//			targetAngle = vectorLeft;
		//			break;
		//		}

		//	case Direction.RIGHT:
		//		{
		//			targetAngle = vectorRight;
		//			break;
		//		}

		//	default:
		//		return;
		//}

		//currentAngle = new Vector3(
		//	 Mathf.LerpAngle(currentAngle.x, targetAngle.x, _singleStep),
		//	 Mathf.LerpAngle(-currentAngle.y, targetAngle.y, _singleStep),
		//	 Mathf.LerpAngle(currentAngle.z, targetAngle.z, _singleStep)
		//	 );

		//transform.eulerAngles = currentAngle;
	}
}
