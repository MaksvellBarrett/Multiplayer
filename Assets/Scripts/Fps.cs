using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fps : MonoBehaviour
{
	public Text FpsView;
	public static float fps;

	private void Start()
	{
		StartCoroutine(CountFpsOneTimePerSecond());
	}
	IEnumerator CountFpsOneTimePerSecond()
	{
		while (true)
		{
			fps = 1.0f / Time.deltaTime;
			FpsView.text = "FPS: " + (int)fps;
			yield return new WaitForSeconds(1);
		}
	}
}
