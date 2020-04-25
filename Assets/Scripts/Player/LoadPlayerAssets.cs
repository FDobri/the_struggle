using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayerAssets : MonoBehaviour
{
    public Sprite femaleCharacter;
    public Sprite maleCharacter;
    public SpriteRenderer spriteRenderer;

    private GameController _gameController;

    // Start is called before the first frame update
    void Start()
    {
        _gameController = GameController.gameControllerInstance;

        if (_gameController != null && _gameController.character.ToString() == "Female")
        {
            spriteRenderer.sprite = femaleCharacter;
        }
        else 
        {
            spriteRenderer.sprite = maleCharacter;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
