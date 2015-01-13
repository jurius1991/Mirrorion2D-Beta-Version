using UnityEngine;
using System.Collections;

public class MedalCheck : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		GameEnd object1 = GetComponent<GameEnd> ();
		CheckPosition object2 = GetComponent<CheckPosition> ();
		GameObject diamondMedal = GameObject.Find ("MedalDiamond");
		GameObject goldMedal = GameObject.Find ("MedalGold");
		GameObject silverMedal = GameObject.Find ("MedalSilver");
		GameObject bronzeMedal = GameObject.Find ("MedalBronze");
		float Timer = object1.Timer;
		if(Timer<2.0f&&object1.RoundRun==false&&object2.isHit==true)
		{
			diamondMedal.renderer.enabled=true;
		}else if(Timer>2&&Timer<4.0f&&object1.RoundRun==false&&object2.isHit==true)
		{
			goldMedal.renderer.enabled=true;
		}else if(Timer>4&&Timer<6.0f&&object1.RoundRun==false&&object2.isHit==true)
		{
			silverMedal.renderer.enabled=true;
		}else if(Timer>6&&Timer<8.0f&&object1.RoundRun==false&&object2.isHit==true)
		{
			bronzeMedal.renderer.enabled=true;
		}
	}
}
