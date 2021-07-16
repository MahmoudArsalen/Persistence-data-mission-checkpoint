using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class MenuManager : MonoBehaviour
{
	public static MenuManager instance;

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

	

}
