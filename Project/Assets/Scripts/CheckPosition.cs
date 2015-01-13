using UnityEngine;
using System.Collections;

public class CheckPosition : MonoBehaviour {

	public bool isHit = false;
	float PlayerPosX, PlayerPosY, HolePosX, HolePosY;
	public float Toleranca=0.3f;

	void Update () {
		CircleCollider2D object1 = GetComponent<CircleCollider2D> ();
		GameObject object2 = GameObject.Find ("BlackHole");
		GameEnd object3 = GetComponent<GameEnd> ();

		//gets player position
		PlayerPosX = gameObject.transform.position.x;
		PlayerPosY = gameObject.transform.position.y;

		//gets hole position
		HolePosX = object2.transform.position.x;
		HolePosY = object2.transform.position.y;

		//On Game end check
		if(Input.GetKey(KeyCode.Space)&&object3.TimesUp!=true)
		{
			object1.enabled=false;
			PlayerPosX = System.Math.Abs(PlayerPosX);
			transform.position = new Vector3 (PlayerPosX, PlayerPosY, 0f);

			if(PlayerPosX>HolePosX-Toleranca&&PlayerPosX<HolePosX+Toleranca&&PlayerPosY>HolePosY-Toleranca&&PlayerPosY<HolePosY+Toleranca)
			{
				Debug.Log("Zadel si luknjo v času: "+object3.Timer+"s");
				isHit=true;
			}else
			{
				Debug.Log("Zgrešil si luknjo");

			}
		}
		object2.renderer.material.color = Color.red;
	}
}
 