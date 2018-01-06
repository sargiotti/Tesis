using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class JuegoTerminado : MonoBehaviour {


	public void OnListo(){
        GameController.INSTANCE.NuevoTurno();
	}
}
