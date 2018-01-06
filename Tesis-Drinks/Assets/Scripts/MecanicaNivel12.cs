using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MecanicaNivel12 : MonoBehaviour {
    public Text consigna;
	// Use this for initialization
	void Start () {
        consigna.text = GameController.INSTANCE.Nombres[GameController.INSTANCE.jugadorActual] + " debe tararear un tema, el que diga el nombre del tema regala 1 sorbo, si nadie adivina en el tiempo dado bebe 5 tragos";

    }
	
}
