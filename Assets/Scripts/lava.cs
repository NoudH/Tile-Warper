using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class lava : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		
		if(other.collider.name == "Player")
		{
			Debug.Log ("You died");
		}
	}

}
