using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour {

	public static float speed=0.2f;
	public static float lifetime=5f;
	public static float increaseFactor=1f;

	public void easygame(){
		speed = 0.2f;
		lifetime = 5f;
		increaseFactor=1f;
		SceneManager.LoadScene ("mainGame");
	}
	public void mediumgame(){
		speed = 0.3f;
		lifetime = 6f;
		increaseFactor=0.9f;
		SceneManager.LoadScene ("mainGame");
	}
	public void hardgame(){
		speed = 0.4f;
		lifetime = 7f;
		increaseFactor=0.8f;
		SceneManager.LoadScene ("mainGame");
	}
	public void exit(){
		Application.Quit ();
	}

}
