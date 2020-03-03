using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public Rigidbody rb;

	public float forwardVel = 20f;
	// public float forwardForce = 2000f;
	public float sideWaysVel = 10f;
	// public float sideWaysForce = 130f;
	// public Score scoreStop;

	// Update is called once per frame

	// Marked this as "Fixed"Update as I'm messing with physics component
	void FixedUpdate()
	{
		// rb.AddForce( 0, 0, forwardForce * Time.deltaTime);
		rb.velocity = new Vector3(0,0,forwardVel);	

		if( Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
		{
			// rb.AddForce( sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			rb.velocity = new Vector3(sideWaysVel, 0, forwardVel);
		}

		if( Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
		{
			// rb.AddForce( -sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			rb.velocity = new Vector3(-sideWaysVel, 0, forwardVel);

		}
		
	}
}
