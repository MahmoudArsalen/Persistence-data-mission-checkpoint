using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class MenuManager : MonoBehaviour
{
	public static MenuManager instance;
	public Text bestScore;
	public string playerName;
	public int score;
	

	
	
	private void Awake()
	{
		if (instance != null)
		{
			Destroy(gameObject);
			return; 
		}
			
		instance = this;
		DontDestroyOnLoad(gameObject);
	}

	private void Start()
	{
		UpdatingUiBestScore(bestScore);
	}

	public void UpdatingUiBestScore(Text bestScoreText)
	{

		bestScoreText.text = "Best Score: " + playerName + " " + score;
	}

	internal void UpdatingUiBestScore(object bestScoreText)
	{
		throw new NotImplementedException();
	}
}
