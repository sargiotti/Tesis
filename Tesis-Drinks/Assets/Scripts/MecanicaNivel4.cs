using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MecanicaNivel4 : MonoBehaviour {

    int R;
    int V;
    public Text numeroRandom;
	void Start () {
        R = Random.Range(1, 50);
        numeroRandom.text = R.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
