using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
// this is a comment
	public Text highScore;
	void Start()
	{
		highScore.text = "High Score : " + ((int)PlayerPrefs.GetFloat("HighScore")).ToString("0") ;
	}
    public void GameStarting()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}