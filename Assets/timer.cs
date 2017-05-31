using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timer : MonoBehaviour {

	public Text timerText;
	private float startTime;
	public static string score="0";

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		float t = Time.time - startTime;
		string second = t.ToString("f2");
		timerText.text = second;
		score = second;
	}
		
}
