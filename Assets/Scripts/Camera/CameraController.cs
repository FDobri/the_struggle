using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public Transform player;
	public float cameraDistance = 20.0f;
    public float smoothCamera = 1.125f;
    public float cameraZ = -15f;

	void Awake()
	{
		//GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
	}

	void LateUpdate()
	{
        transform.position = new Vector3(Mathf.Lerp(this.transform.position.x, player.transform.position.x, Time.deltaTime * smoothCamera),
                                        Mathf.Lerp(this.transform.position.y, player.transform.position.y, Time.deltaTime * smoothCamera), cameraZ);


    }
}

