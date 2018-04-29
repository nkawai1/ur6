using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballkesu : MonoBehaviour {
	
	int count;
	private float timeInterval=0.5f;
	private float timeElapsed;


	// Use this for initialization
	void Start () {
		
		//this.director = GameObject.Find ("GameDirector");

		//obj = GameObject.Find ("Explosion loop fallback");
		//ps = obj.GetComponent<ParticleSystem> ();
		//obj.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		
		//transform.Translate(Vector3.up * Time.deltaTime * (transform.localScale.x * 0.5f));

		//transform.RotateAround(transform.position, transform.up, Time.deltaTime * 150f);
		//Vector3 tmp = this.transform.position;
		//transform.position = new Vector3(tmp.x , tmp.y, tmp.z);
		//float y = tmp.y;
		//if (y >= 10.0f) {
		//this.director.GetComponent<GameDirector> ().Getover();
		//hantei = true;
		//GetComponent<Rigidbody> ().isKinematic = false;
		//obj.SetActive (true);
		//ps.Play ();
		timeElapsed += Time.deltaTime;
		if (timeElapsed >= timeInterval) {
			if (count == 0) {
				float x1 = Random.Range (-2.0f, 2.0f);
				float y1 = Random.Range (0.3f, 2.0f);
				float z1 = Random.Range (0.3f, 2.0f);
				this.transform.position += new Vector3 (x1, y1, z1);
				//BoxCollider col = GetComponent<SphereCollider> ();
				//col.isTrigger = true; 
				count++;
			}
		}
	}

}
