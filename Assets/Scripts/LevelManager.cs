using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject Floor;
	public GameObject Lava;
	public GameObject Player;
	[Space(8)]
	[Header("Dimensions:")]
	public int X;
	public int Y;

	// Use this for initialization
	void Start () 
	{
		Player.transform.position = new Vector3 (X * 5, 0.55f, Y * 5);
		GameObject lava = (GameObject)Instantiate (Lava, new Vector3 ((X-1) * 5, -0.5f, (Y-1) * 5), Quaternion.identity);
		lava.transform.localScale = new Vector3 ((X+6)*10,1,(Y+6)*10);
		for (int x = 0; x < X; x++) {
			for (int y = 0; y < Y; y++) {
				Vector3 Coord = new Vector3 (x*10,0,y*10);
				GameObject go = (GameObject)Instantiate (Floor, Coord, Quaternion.identity);
				go.transform.parent = transform;
			}
		}
	}
}
