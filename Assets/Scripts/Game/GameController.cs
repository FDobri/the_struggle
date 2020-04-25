using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterType
{
	Male,
	Female
}

public class GameController : MonoBehaviour
{
	public static GameController gameControllerInstance;

	[HideInInspector]
	public CharacterType character;

	// Start is called before the first frame update
	void Awake()
    {
		if (gameControllerInstance == null)
		{
			gameControllerInstance = this;
		}
		else
		{
			Destroy(gameObject);
			return;
		}

		DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
