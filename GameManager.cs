using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
	public Transform player;
	public GameObject platformGO;
	public GameObject obstacleGO;
	public float zPosPlat = 0f;
	bool GameHasEnded = false;


    public void EndGame()
	{
			GameHasEnded = true;
			Debug.Log( "Game Over" );
	}

	void Start()
	{
		for(int i = 0 ; i < 40 ; i++)
		{
			Instantiate(platformGO , new Vector3(-7,8,zPosPlat) , platformGO.transform.rotation);
			zPosPlat += 2;
		}
	}

	void Update()
	{
		if(GameHasEnded == false)
		{
			int RandNo = Random.Range(0,7);
			if (RandNo < 2 )
			{
				float Xvalue = Random.Range(-6,6);
				Instantiate(obstacleGO , new Vector3(Xvalue,1.5f,zPosPlat) , obstacleGO.transform.rotation);
			}
			Instantiate(platformGO , new Vector3(-7,8,zPosPlat) , platformGO.transform.rotation);
			zPosPlat += 2;

			GameObject DeleteG = GameObject.FindWithTag("Ground");
			GameObject DeleteO = GameObject.FindWithTag("Obstacle");
			if(DeleteO.transform.position.z + 4 < player.position.z)
			{
				Destroy(DeleteO);
			}
			if(DeleteG.transform.position.z + 10 < player.position.z && DeleteG.tag == "Ground")
			{
				Destroy(DeleteG);
			}	
		}
		
		
	}


}
