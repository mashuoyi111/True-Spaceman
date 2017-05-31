using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class randomEnemyBahavior : MonoBehaviour {

	private float speed=startGame.speed;
	private float lifetime=startGame.lifetime;
	private float increaseF=startGame.increaseFactor;
	private float productionRate;
	private float currentRate;
	private int numToRun=80;
	void Start(){
		Sprite.Destroy (this.gameObject,lifetime);
		productionRate = Random.Range (90*increaseF, 130*increaseF);
		currentRate = productionRate;
		transform.Rotate (0,0, Random.Range (-180,180));
	}

	// Update is called once per frame
	void Update () {
		int a=0;
		if (numToRun <= 0) {
			a = Random.Range (-180,180);
			transform.Rotate (0,0, a);
			numToRun = Random.Range(30,120);
//			GameObject mySprite=Sprite.Instantiate (GameObject.Find("bullet"));
//			mySprite.gameObject.AddComponent<randomEnemyBahavior> ();
			//numToRun = Random.Range(1,80);
		}
		if (currentRate <= 0) {
			Sprite.Instantiate (this.gameObject);
			currentRate = productionRate;
		}
		transform.Translate(Vector2.up * speed);
		numToRun--;
		currentRate--;
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Wall") {
			transform.Rotate (0,0, 180);
			numToRun = Random.Range(60,120);
		}
		if (col.gameObject.tag == "Player") {
			SceneManager.LoadScene ("gameover");
		}
	}


}
