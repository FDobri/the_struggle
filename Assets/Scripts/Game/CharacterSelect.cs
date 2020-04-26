using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
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
		_CharacterActivity(_gameController.character.ToString());
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void OnSelectCharacter(string type)
	{
		Enum.TryParse(type, out _gameController.character);
		_CharacterActivity(type);
		//Debug.Log(_gameController.character + " selected!");
	}

	private void _CharacterActivity(string type)
	{
		Color32 inactiveColor = new Color32(65, 65, 65, 155);
		Color32 activeColor = new Color32(255, 255, 255, 255);

		Color32 inactiveColorText = new Color32(65, 65, 65, 155);
		Color32 activeColorText = new Color32(77, 51, 8, 255);


		if (type == "Female")
		{
			characterLeft.GetComponent<Image>().color = inactiveColor;
			characterLeft.GetComponentInChildren<Text>().color = inactiveColorText;

			characterRight.GetComponent<Image>().color = activeColor;
			characterRight.GetComponentInChildren<Text>().color = activeColorText;
		}
		else
		{
			characterLeft.GetComponent<Image>().color = activeColor;
			characterLeft.GetComponentInChildren<Text>().color = activeColorText;

			characterRight.GetComponent<Image>().color = inactiveColor;
			characterRight.GetComponentInChildren<Text>().color = inactiveColorText;
		}
	}
}
