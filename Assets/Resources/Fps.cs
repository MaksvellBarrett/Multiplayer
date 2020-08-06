﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fps : MonoBehaviour
{
	public Text FpsString;
	public static float fps;

	private void Start()
	{
		StartCoroutine(FpsQuratin());
	}
	IEnumerator FpsQuratin()
	{
		while (true)
		{
			fps = 1.0f / Time.deltaTime;
			FpsString.text = "FPS: " + (int)fps;
			yield return new WaitForSeconds(1);
		}
	}
}