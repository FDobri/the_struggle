using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	private Transform _player;
	public float cameraDistance = 20.0f;
    public float smoothCamera = 1.125f;
    public float cameraZ = -15f;

	void Start()
	{
		_player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	void LateUpdate()
	{
		if (_player == null)
		{
			return;
		}

        transform.position = new Vector3(Mathf.Lerp(this.transform.position.x, _player.transform.position.x, Time.deltaTime * smoothCamera),
                                        Mathf.Lerp(this.transform.position.y, _player.transform.position.y, Time.deltaTime * smoothCamera), cameraZ);
    }
}

