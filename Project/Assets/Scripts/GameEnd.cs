using UnityEngine;
using System.Collections;

public class GameEnd : MonoBehaviour
{
	public bool TimeCount=false;
	public bool RoundRun=false;
	public bool RoundStart = false;
	public bool TimesUp = false;
	public float Timer=0.0f;
	public float TimeEnd=10.0f;


	// Update is called once per frame
	void FixedUpdate ()
	{
		PlayerMovement object1 = GetComponent<PlayerMovement> ();
		//increasing time
		if (TimeCount == true)
		{
			Timer=Timer+1*Time.deltaTime;
			Debug.Log(Timer);
		}
		
		//allows player to move if he inputs something and time is still running
		if ((Input.GetKey(KeyCode.W) || Input.GetKey (KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && object1.isMovement==true && RoundStart==false)
		{
			TimeCount=true;
			RoundRun=true;
		}

		//checks if you hit space
		if(Input.GetKey(KeyCode.Space))
		{
			TimeCount=false;
			object1.isMovement=false;
			RoundRun=false;
		}

		//checks if time is up
		if(Timer>TimeEnd)
		{
			TimeCount=false;
			TimesUp=true;
			RoundRun=false;
			object1.isMovement=false;
			Debug.Log("Time's up!");
		}
	}
}