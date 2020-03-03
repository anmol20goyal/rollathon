using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
	public Text scoreText;

    public float original_pos;
	public float pos_in_game;
    void Start()
    {
        original_pos = player.position.z;
    }
    void Update()
    {
		pos_in_game = (player.position.z - original_pos)/10;
        scoreText.text = (pos_in_game).ToString("0");
    } 
}