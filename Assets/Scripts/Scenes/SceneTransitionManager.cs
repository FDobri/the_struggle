using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
	public static string levelName;
	public void ChangeScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
		levelName = sceneName;
	}

	public void ResetScene()
	{
		string sceneName = SceneManager.GetActiveScene().name;
		SceneManager.LoadScene(sceneName);
		levelName = sceneName;
	}
}
