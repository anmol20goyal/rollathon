using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    public Text finalScore;
    public Text Score;
    void Start()
    {
        finalScore.text = "Score : " + Score.text;
    }
}
