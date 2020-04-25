using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDirectionSetter : MonoBehaviour
{
    public float RotationSpeed = 20.0f;
    public PlayerMovementController playerMovementController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDirection = new Vector3(55.0f, 0.0f, 0.0f);
        Direction _playerDirection = playerMovementController.GetPlayerDirection();

        /*float singleStep = 20.0f * Time.deltaTime;
        switch (_playerDirection)
        {
            case Direction.LEFT:
                {
                    Vector3 targetAngle = new Vector3(0f, 181f, 0f);

                    Vector3 currentAngle = transform.eulerAngles;

                    currentAngle = new Vector3(
                         Mathf.LerpAngle(currentAngle.x, targetAngle.x, singleStep),
                         Mathf.LerpAngle(-currentAngle.y, targetAngle.y, singleStep),
                         Mathf.LerpAngle(currentAngle.z, targetAngle.z, singleStep));

                    transform.eulerAngles = currentAngle;
                    break;
                }

            case Direction.RIGHT:
                {
                    Vector3 targetAngle = new Vector3(0f, 0f, 0f);

                    Vector3 currentAngle = transform.eulerAngles;

                    currentAngle = new Vector3(
                         Mathf.LerpAngle(currentAngle.x, targetAngle.x, singleStep),
                         Mathf.LerpAngle(-currentAngle.y, targetAngle.y, singleStep),
                         Mathf.LerpAngle(currentAngle.z, targetAngle.z, singleStep));

                    transform.eulerAngles = currentAngle;
                    break;
                }

            default:
                break;

        }
        */
    }
}
