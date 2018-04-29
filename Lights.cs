using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour {

	//最初はライトはOffにしておきます
	void Start()
	{
		//LightのGameObjectをfrueにして表示します。ライトが消えています
		gameObject.SetActive(false);
	}
	//ライトオンの処理
	public void LightsOn()
	{
		//LightのGameObjectをtrueにして表示します。ライトが点灯します
		gameObject.SetActive(true);
	}
	//ライトオフの処理
	public void LightsOff()
	{
		//LightのGameObjectをfalseにします、するとライトが消えます
		gameObject.SetActive(false);
	}
}
