using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ItemJugador : MonoBehaviour {

	public GameObject button;
	public InputField CajaTxt;

	void OnAgregar(){	//Click en boton "+"
		
		MenuController.MenuINSTANCE.OnAgregar (button, CajaTxt);
	}
	void OnEmpezar(){

		GameController.INSTANCE.OnEmpezar ();
	}


}