using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelController : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject OutroPrefab;
    public SceneTransitionManager sceneTransitionManager;
    public string NextSceneName;

    public float sceneChangeTimeOut = 1.85f;
    private bool playerTriggeredEndSceneEvent = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (playerTriggeredEndSceneEvent)
        {
            sceneChangeTimeOut -= Time.deltaTime;
            if (sceneChangeTimeOut < 0f)
            {
                sceneTransitionManager.ChangeScene(NextSceneName);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (playerTriggeredEndSceneEvent)
        {
            return;
        }

        playerTriggeredEndSceneEvent = true;
        Instantiate(OutroPrefab, MainCamera.transform);
    }
}
