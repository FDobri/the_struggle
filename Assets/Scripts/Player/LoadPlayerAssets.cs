using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayerAssets : MonoBehaviour
{
    public Sprite femaleCharacterEvil;
    public Sprite femaleCharacterGood;
    public Sprite maleCharacterEvil;
    public Sprite maleCharacterGood;
    public SpriteRenderer spriteRenderer;

    private GameController _gameController;

    // Start is called before the first frame update
    void Start()
    {
        _gameController = GameController.gameControllerInstance;

        if (_gameController != null && _gameController.character.ToString() == "Female")
        {
            if (SceneTransitionManager.levelName == "Scene_02" || SceneTransitionManager.levelName == "Scene_04")
            {
                spriteRenderer.sprite = femaleCharacterEvil;
            }
            else
            {
                spriteRenderer.sprite = femaleCharacterGood;
            }
                
        }
        else 
        {
            if (SceneTransitionManager.levelName == "Scene_02" || SceneTransitionManager.levelName == "Scene_04")
            {
                spriteRenderer.sprite = maleCharacterEvil;
            }
            else
            {
                spriteRenderer.sprite = maleCharacterGood;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
