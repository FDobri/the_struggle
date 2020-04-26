using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBossSpawner : MonoBehaviour
{
    public GameObject bossMale;
    public GameObject bossFemale;

    private GameController _gameController;

    public static GameObject activeBoss;
    // Start is called before the first frame update
    void Start()
    {
        _gameController = GameController.gameControllerInstance; 
        if (_gameController.character.ToString() == "Female")
        {
            bossFemale.SetActive(true);
            activeBoss = bossFemale;
        }
        else 
        {
            bossMale.SetActive(true);
            activeBoss = bossMale;
        }

    }
}
