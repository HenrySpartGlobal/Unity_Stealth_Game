using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour {

	public GameObject gameOver;
	public GameObject gameWin;
	bool gameIsOver;

	// Use this for initialization
	void Start () {
		Guard.OnGuardHasSpottedPlayer += ShowGameLose;
		//if player reaches the end, show game win UI
		FindObjectOfType<Player>().OnReachEndOfLevel += ShowGameWin;

	}

	void Update () {
		if (gameIsOver) {
			if (Input.GetKeyDown(KeyCode.Space)){
				SceneManager.LoadScene (0);
			}
		}

	}

	void ShowGameWin(){
		OnGameOver (gameWin);
	}

	void ShowGameLose(){
		OnGameOver (gameOver);
	}

	void OnGameOver(GameObject gameOver) {
		gameOver.SetActive(true);
		gameIsOver = true;
		Guard.OnGuardHasSpottedPlayer -= ShowGameLose;
		//if player reaches the end, show gameover UI
		FindObjectOfType<Player>().OnReachEndOfLevel -= ShowGameWin;
	}
}
