using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Consignas : MonoBehaviour {


    public Text texto;
    public Random random;

    string[] consigna1 = { "el ultimo en tocarse la nariz bebe 3 tragos", "yo nunca...", "jugador3 bebe 2 tragos" };
   //string consigna2 = "yo nunca...";
    //string consigna3 = "jugadorX bebe 2 tragos";

    // Use this for initialization
    void Start () {
        texto.text = consigna1[Random.Range(0, 3)];

	}
	
	// Update is called once per frame
	void Update () {
            if (Input.GetMouseButtonDown(0)) {
            texto.text = consigna1[Random.Range(0, 3)];
            }
    }
}
