using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayerAssetsNew : MonoBehaviour
{
    public Vector3 PlayerSpawnPoint;
    public GameObject femaleCharacterEvil;
    public GameObject femaleCharacterGood;
    public GameObject maleCharacterEvil;
    public GameObject maleCharacterGood;

    private GameController _gameController;

    void Awake()
    {
        Debug.Log("Awake time");
        _gameController = GameController.gameControllerInstance;

        if (_gameController != null && _gameController.character.ToString() == "Female")
        {
            if (SceneTransitionManager.levelName == "Scene_02" || SceneTransitionManager.levelName == "Scene_04")
            {
                //Instantiate(femaleCharacterEvil);
                Instantiate(femaleCharacterEvil, PlayerSpawnPoint, Quaternion.identity);
            }
            else
            {

                Instantiate(femaleCharacterGood, PlayerSpawnPoint, Quaternion.identity);
            }

        }
        else
        {
            if (SceneTransitionManager.levelName == "Scene_02" || SceneTransitionManager.levelName == "Scene_04")
            {
                //spriteRenderer.sprite = maleCharacterEvil;
                Instantiate(maleCharacterEvil, PlayerSpawnPoint, Quaternion.identity);
            }
            else
            {
                //Instantiate(maleCharacterGood);
                Instantiate(maleCharacterGood, PlayerSpawnPoint, Quaternion.identity);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start time");
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
