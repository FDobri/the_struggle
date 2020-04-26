using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneTextMover : MonoBehaviour
{
    public float TextMoveSpeed = 1.5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newX = gameObject.transform.position.x;
        float newY = gameObject.transform.position.y + TextMoveSpeed * Time.deltaTime;
        float newZ = gameObject.transform.position.z + TextMoveSpeed * Time.deltaTime;
        gameObject.transform.position = new Vector3(newX, newY, newZ);

        if (newY > 100f)
        {
            Destroy(gameObject);
        }
    }
}
