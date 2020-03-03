﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
	
	public void Quit()
	{
		Debug.Log("Quit");
		Application.Quit();
	}

	public void PlayAgain()
	{
		SceneManager.LoadScene("Endless");
	}

	public void Menu()
	{
		SceneManager.LoadScene("Menu");
	}
}
