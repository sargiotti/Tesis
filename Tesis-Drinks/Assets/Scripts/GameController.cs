using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameController : MonoBehaviour {

	public int jugadorActual = 0;									//indice para array

	public List<string> Nombres = new List<string> ();	//Nombre de todos los jugadores

	public static GameController INSTANCE;				//Para acceder desde cualquier elemento


	void Awake(){
		if (INSTANCE == null) {
			INSTANCE = this;
		}
	}

	public void QuitRequest () {
		Debug.Log("you quitted the game");
		Application.Quit();
	}
	public void Update() {
		Scene scene = SceneManager.GetActiveScene();
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if (scene.name == "MenuPrincipal") {
				Application.Quit();
			} else  {
				SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
			}
		}
	}


	public void NuevoTurno(){
		if (jugadorActual < Nombres.Count-1) {
            jugadorActual++;
		} else {
            jugadorActual = 0;
		}
		SceneManager.LoadScene("TurnosReloj", LoadSceneMode.Single);

	}

	public void OnEmpezar(){
		for (int i = 0; i < Nombres.Count; i++) {
			Debug.Log ("Jugador " + i + ": " + Nombres [i]);
		}
		if (Nombres.Count == 0) {

		} else {
			SceneManager.LoadScene("TurnosReloj", LoadSceneMode.Single);
		}
	}
}