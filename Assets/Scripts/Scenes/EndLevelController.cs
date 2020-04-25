using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelController : MonoBehaviour
{
    public SceneTransitionManager sceneTransitionManager;
    public string NextSceneName;
    public GameObject Player;

    private bool playerTriggeredEndSceneEvent = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (playerTriggeredEndSceneEvent)
        {
            return;
        }

        playerTriggeredEndSceneEvent = true;
        sceneTransitionManager.ChangeScene(NextSceneName);
    }
}
