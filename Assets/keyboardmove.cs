using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class keyboardmove : MonoBehaviour {

	public float speed;
		
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)||Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector2.up * speed);
		}
		if (Input.GetKey (KeyCode.D)||Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector2.right * speed);
		}
		if (Input.GetKey (KeyCode.A)||Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector2.left * speed);
		}
		if (Input.GetKey (KeyCode.S)||Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (Vector2.down * speed);
		}
	}



}
