using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFloor : MonoBehaviour {

	public GameObject Player;

	void Start()
	{
		Player = GameObject.FindGameObjectWithTag ("Player");
	}

	void OnMouseDown()
	{
		Player.transform.position = transform.position + new Vector3(0,0.6f,0);
	}
}
