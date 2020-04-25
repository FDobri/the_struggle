using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class PlayerDirectionSetter : MonoBehaviour
{
	public float RotationSpeed = 20.0f;
	public PlayerMovementController playerMovementController;
	private float _singleStep = 0f;

	void Update()
	{
		Direction _playerDirection = playerMovementController.GetPlayerDirection();

		Vector3 currentAngle = transform.eulerAngles;
		Vector3 targetAngle;

		_singleStep = RotationSpeed * Time.deltaTime;
		switch (_playerDirection)
		{
			case Direction.LEFT:
				{
					targetAngle = new Vector3(0f, 181f, 0f);
					break;
				}

			case Direction.RIGHT:
				{
					targetAngle = new Vector3(0f, 0f, 0f);
					break;
				}

			default:
				return;
		}

		currentAngle = new Vector3(
			 Mathf.LerpAngle(currentAngle.x, targetAngle.x, _singleStep),
			 Mathf.LerpAngle(-currentAngle.y, targetAngle.y, _singleStep),
			 Mathf.LerpAngle(currentAngle.z, targetAngle.z, _singleStep)
			 );

		transform.eulerAngles = currentAngle;

	}
}
