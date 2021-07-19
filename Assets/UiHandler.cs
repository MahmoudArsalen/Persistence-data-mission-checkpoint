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
	public InputField enterName;

	private void Start()
	{
		if(!string.IsNullOrEmpty(MenuManager.instance.playerName))
		{
			enterName.text = MenuManager.instance.playerName;
		}
		
			MenuManager.instance.UpdatingUiBestScore(bestScoreText);
	}


	public void StartGame()
	{
		if(MenuManager.instance != null )
		{
			if(!string.IsNullOrEmpty(enterName.text))
			{
				MenuManager.instance.score = 0;
				MenuManager.instance.playerName = enterName.text;
			}
			
		}
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void QuitGame()
	{
		if(MenuManager.instance != null)
		{
			MenuManager.instance.SavePlayerInfo();
		}
#if UNITY_EDITOR
		EditorApplication.ExitPlaymode();
#else
		Application.Quit();
#endif

	}

	
}
