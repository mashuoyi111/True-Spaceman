using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour {


	public void restart(){
		SceneManager.LoadScene("mainGame");
	}

	public void mainMenu(){
		SceneManager.LoadScene("startMenu");
	}


}
