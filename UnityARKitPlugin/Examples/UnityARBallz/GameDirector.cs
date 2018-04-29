using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameDirector : MonoBehaviour {
	//GameObject[] enemyObjects;
	int count = 0;
	GameObject pointText;
	GameObject obaText;
	GameObject timerText;
	float time=60.0f;
	GameObject obj;
	ParticleSystem ps;
	// Use this for initialization
	void Start () {
		this.pointText = GameObject.Find ("kazoeru");
		this.timerText = GameObject.Find ("jikan");
		this.obaText = GameObject.Find ("gemeoba");
		obaText.GetComponent<Text>().enabled = false;
		obj = GameObject.Find("Explosion loop fallback");
		ps = obj.GetComponent<ParticleSystem>();
		obj.SetActive(false);
	}
	void DelayMethod()
	{
		SceneManager.LoadScene ("title");
	}
	public void Gettensu(){
		time = 60.0f;
		count=count+10;
	}


	// Update is called once per frame
	void Update () {
		this.time -= Time.deltaTime;
		this.timerText.GetComponent<Text>().text = this.time.ToString ("F1");
		this.pointText.GetComponent<Text>().text = this.count.ToString ()+" Point";
		if (time <= 0.0f) {
			Invoke("DelayMethod", 5.0f);
			obaText.GetComponent<Text>().enabled = true;
			obj.SetActive(true);
			ps.Play();
			GetComponent<AudioSource> ().Play ();
		}

	}
}
