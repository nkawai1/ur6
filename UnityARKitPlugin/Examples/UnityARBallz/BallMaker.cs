using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.iOS;

public class BallMaker : MonoBehaviour {

	public GameObject ballPrefab;

	public float createHeight;
	private MaterialPropertyBlock props;
	private float timeInterval=2.0f; // モグラの出現間隔（秒）
	private float timeElapsed; // 経過時間を保存する変数
	int count=0;
	// Use this for initialization
	void Start () {
		props = new MaterialPropertyBlock ();

	}

	void CreateBall(Vector3 atPosition)
	{
		GameObject ballGO = Instantiate (ballPrefab, atPosition, Quaternion.identity);
			
		
		float r = Random.Range(0.0f, 1.0f);
		float g = Random.Range(0.0f, 1.0f);
		float b = Random.Range(0.0f, 1.0f);

		props.SetColor("_InstanceColor", new Color(r, g, b));

		MeshRenderer renderer = ballGO.GetComponent<MeshRenderer>();
		renderer.SetPropertyBlock(props);

	}

	// Update is called once per frame
	void Update () {
		
		// 一定時間が経過したらHitTestを実行する
		timeElapsed += Time.deltaTime;
		if(timeElapsed >= timeInterval) {
			_executeHitTest ();
			timeElapsed = 0.0f;
				
		}
	}

	private void _executeHitTest() {
		// 画面上のランダムな座標を元にARPointをセット
		var screenPosition = Camera.main.ScreenToViewportPoint(new Vector3 (Screen.width * Random.value, Screen.height * Random.value));
		ARPoint point = new ARPoint {
			x = screenPosition.x,
			y = screenPosition.y
		};

		// HitTestを実行する
		List<ARHitTestResult> hitResults = UnityARSessionNativeInterface.GetARSessionNativeInterface ().HitTest (point, ARHitTestResultType.ARHitTestResultTypeExistingPlaneUsingExtent);

		// 平面と衝突した位置にモグラを出現させる
		if (hitResults.Count > 0) {
			foreach (var hitResult in hitResults) {
				Vector3 position = UnityARMatrixOps.GetPosition (hitResult.worldTransform);
				CreateBall(position);
				break;
			}
		}
	}

	 

	}


