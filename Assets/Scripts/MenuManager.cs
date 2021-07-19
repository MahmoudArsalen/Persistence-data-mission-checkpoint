using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.IO;


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
		LoadPlayerInfo();
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




	#region SaveDataBetweenSessions
	class SaveData
	{
		public int score;
		public string playerName;
	}

	public void SavePlayerInfo()
	{
		SaveData data = new SaveData();
		data.playerName = playerName;
		data.score = score;

		string json = JsonUtility.ToJson(data);

		File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
	}

	public void LoadPlayerInfo()
	{
		string path = Application.persistentDataPath + "/savefile.json";

		if(File.Exists(path))
		{
			String json = File.ReadAllText(path);

			SaveData data = JsonUtility.FromJson<SaveData>(json);

			score = data.score;
			playerName = data.playerName;
		}
		

	}
	#endregion
}
