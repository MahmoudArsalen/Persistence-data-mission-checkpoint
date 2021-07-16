using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class UiHandler : MonoBehaviour
{
	public Text bestScoreText;

	private void Start()
	{
		UpdatingUiBestScore();
	}


	public void StartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void QuitGame()
	{
#if UNITY_EDITOR
		EditorApplication.ExitPlaymode();
#else
		Application.Quit();
#endif

	}

	public void UpdatingUiBestScore()
	{
		
		bestScoreText.text = "Best Score: " + MenuManager.instance.score;
	}
}
