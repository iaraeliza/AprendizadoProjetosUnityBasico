using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptCenas : MonoBehaviour
{
    void LoadScene()
	{
		SceneManager.LoadScene("Scene01");
		SceneManager.LoadScene(1);
		SceneManager.LoadSceneAsync(1);
		SceneManager.LoadScene("Scene01", LoadSceneMode.Single);
		SceneManager.LoadScene("Scene01", LoadSceneMode.Additive);
	}

	public void LoadSceneWithParameterStr(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}

	public void LoadSceneWithParameterInt(int sceneIndex)
	{
		SceneManager.LoadScene(sceneIndex);
	}

	public void UnloadScene(string sceneName)
	{
		SceneManager.UnloadSceneAsync(sceneName);
	}

	void RestartScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
