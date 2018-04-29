using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generetor : MonoBehaviour {
	public GameObject BallPrefab1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject igaguri = Instantiate (BallPrefab1) as GameObject;

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			Vector3 worldDir = ray.direction;
			igaguri.GetComponent<ballcontroller> ().Shoot (worldDir.normalized * 1000);
		}
	}
}
