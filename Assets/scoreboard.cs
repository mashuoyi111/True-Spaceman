using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreboard : MonoBehaviour {
	public Text current;
	// Use this for initialization
	void Start () {
		current.text = timer.score;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
