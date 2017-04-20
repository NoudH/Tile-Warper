using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class lava : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		
		if(other.collider.name == "Player")
		{
			Scene scene = SceneManager.GetActiveScene ();
			SceneManager.LoadScene (scene.buildIndex);
			//SceneManager.SetActiveScene (scene);
		}
	}

}
