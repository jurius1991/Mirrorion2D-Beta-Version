using UnityEngine;
using System.Collections;

public class BlackHoleSpawn : MonoBehaviour
{
	float MinX=0.7f;
	float MaxX=5.75f;
	float MinY=-2.95f;
	float MaxY=2.95f;
	void Start ()
	{
		transform.position = new Vector2 (Random.Range(MinX, MaxX), Random.Range(MinY, MaxY));
	}
}