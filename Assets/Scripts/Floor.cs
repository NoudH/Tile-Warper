using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Floor : MonoBehaviour {

	public float minTimer;
	public float maxTimer;

	public Renderer rend;
	private float timer;

	// Update is called once per frame
	IEnumerator Start () 
	{
		while(true)
		{
			
			rend.material.color = Color.green;
			timer = Random.Range (minTimer, maxTimer);
			Mathf.RoundToInt (timer);
			yield return new WaitForSeconds (timer - 1);
			rend.material.color = Color.yellow;
			yield return new WaitForSeconds (1);
			gameObject.GetComponent<MeshRenderer> ().enabled = false;
			gameObject.GetComponent<BoxCollider> ().enabled = false;
			yield return new WaitForSeconds (2);
			gameObject.GetComponent<MeshRenderer> ().enabled = true;
			gameObject.GetComponent<BoxCollider> ().enabled = true;
		}
	}
		
}
