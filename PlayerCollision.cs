using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
	public GameObject gameOverUI; 
	public PlayerMovement movement;
	public Score scoreStop;
	void OnCollisionEnter(Collision collisionInfo)
	{
		if(collisionInfo.collider.tag == "Obstacle")
		{
			if(PlayerPrefs.GetFloat("HighScore") < scoreStop.pos_in_game)
			{
				PlayerPrefs.SetFloat("HighScore",scoreStop.pos_in_game);
			}
			gameOverUI.SetActive(true);
			movement.enabled = false;
			scoreStop.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}	
	}


}
