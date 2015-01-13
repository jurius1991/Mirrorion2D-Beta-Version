using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public float Speed=10.0f;
	public bool isMovement=true;
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.W)&&isMovement==true)
		{
			transform.Translate(Vector3.up*Time.deltaTime*Speed);
		}

		if (Input.GetKey (KeyCode.A)&&isMovement==true)
		{
			transform.Translate(Vector3.left*Time.deltaTime*Speed);
		}

		if (Input.GetKey (KeyCode.S)&&isMovement==true)
		{
			transform.Translate(Vector3.down*Time.deltaTime*Speed);
		}

		if (Input.GetKey (KeyCode.D)&&isMovement==true)
		{
			transform.Translate(Vector3.right*Time.deltaTime*Speed);
		}
		if (Input.GetKey (KeyCode.Space))
		{
			isMovement=false;
		}
	}
}
