using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
	public Button characterLeft;
	public Button characterRight;

	private GameController _gameController;

    // Start is called before the first frame update
    void Start()
    {
		_gameController = GameController.gameControllerInstance;
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void OnSelectCharacter(string type)
	{
		Enum.TryParse(type, out _gameController.character);
		Debug.Log(_gameController.character + " selected!");
	}
}
