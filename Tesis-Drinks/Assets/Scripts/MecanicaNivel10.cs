using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MecanicaNivel10 : MonoBehaviour {

    public Text consigna;

	void Start () {
        consigna.text = GameController.INSTANCE.Nombres[GameController.INSTANCE.jugadorActual] + " ,Debe elegir una persona para que beba";

    }
	
}
