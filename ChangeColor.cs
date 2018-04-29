using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	Renderer[] rn;

	void Start()
	{
		// GetComponentsInChildrenで、子供も含めたRenderコンポーネントを取得して、
		//rnで参照する
		rn = gameObject.GetComponentsInChildren<Renderer>();

	}
	//赤いボタンがタップされたとき
	public void Red()
	{
		//ボディの色をredにする
		rn[0].material.color = Color.red;
	}
	//青いボタンがタップされたとき
	public void Blue()
	{
		//ボディの色をblueにする 
		rn[0].material.color = Color.blue;
	}
	//緑のボタンがタップされたとき
	public void Green()
	{
		//ボディの色をgreenにする
		rn[0].material.color = Color.green;
	}
	//ゴールドのボタンがタップされたとき
	public void Gold()
	{
		//ボディの色をyellowにする
		rn[0].material.color = Color.yellow;
	}

}
