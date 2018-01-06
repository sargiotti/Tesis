using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SeteoText : MonoBehaviour {

	public Text txtTurno;
	public Text txtAzar;
	public GameObject btnJugar;

	int R = 0;
	// Use this for initialization
	void Start () {
        txtTurno.text = "Es el turno de: " + GameController.INSTANCE.Nombres [GameController.INSTANCE.jugadorActual];
	}
	
	// Update is called once per frame
	void Update () {
        Scene scene = SceneManager.GetActiveScene();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (scene.name == "MenuPrincipal")
            {
                Application.Quit();
            }
            else
            {
                SceneManager.LoadScene("MenuPrincipal", LoadSceneMode.Single);
            }
        }
    }

	public void OnEmpezar(){
			R = Random.Range (1, 13);
			float time = Time.deltaTime;
			txtAzar.text = R.ToString ();
			Debug.Log (R.ToString ());

			R = Random.Range (1, 13);
			txtAzar.text = R.ToString ();
			Debug.Log (R.ToString ());

			 R = Random.Range (1, 13);
			txtAzar.text = R.ToString ();
			Debug.Log (R.ToString ());

			R = Random.Range (1, 13);
			txtAzar.text = R.ToString ();
			Debug.Log (R.ToString ());
	
			R = Random.Range (1, 13);
			txtAzar.text = "Juego numero: "+R.ToString ();
			Debug.Log (R.ToString ());
			
			btnJugar.SetActive (true);
	}

	public void OnJugar(){
		switch (R) {
		case 1:
			SceneManager.LoadScene("Juego1", LoadSceneMode.Single);
			break;
		case 2:
			SceneManager.LoadScene("Juego2", LoadSceneMode.Single);
			break;
		case 3:
			SceneManager.LoadScene("Juego3", LoadSceneMode.Single);
			break;
		case 4:
			SceneManager.LoadScene("Juego4", LoadSceneMode.Single);
			break;
		case 5:
			SceneManager.LoadScene("Juego5", LoadSceneMode.Single);
			break;
		case 6:
			SceneManager.LoadScene("Juego6", LoadSceneMode.Single);
			break;
		case 7:
			SceneManager.LoadScene("Juego7", LoadSceneMode.Single);
			break;
		case 8:
			SceneManager.LoadScene("Juego8", LoadSceneMode.Single);
			break;
		case 9:
			SceneManager.LoadScene("Juego9", LoadSceneMode.Single);
			break;
		case 10:
			SceneManager.LoadScene("Juego10", LoadSceneMode.Single);
			break;
		case 11:
			SceneManager.LoadScene("Juego11", LoadSceneMode.Single);
			break;
		case 12:
			SceneManager.LoadScene("Juego12", LoadSceneMode.Single);
			break;
		default:
			break;
		}
	}


}
