using UnityEngine;
using UnityEngine.SceneManagement;
public class OpenCredits : MonoBehaviour
{
	public void LoadNextSlide()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
