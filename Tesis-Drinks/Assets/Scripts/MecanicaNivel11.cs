using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MecanicaNivel11 : MonoBehaviour {

    public Text consigna;
	// Use this for initialization
	void Start () {
        consigna.text = GameController.INSTANCE.Nombres[GameController.INSTANCE.jugadorActual] + " debe elegir una palabra y no podra ser usada hasta el fin del juego";

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
