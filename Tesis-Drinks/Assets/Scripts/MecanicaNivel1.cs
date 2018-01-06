using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MecanicaNivel1 : MonoBehaviour {

    public Text texto;

   
    void Start () {
        texto.text = GameController.INSTANCE.Nombres[GameController.INSTANCE.jugadorActual] + " toma 1 trago";

    }

    // Update is called once per frame
    void Update () {
        
    }
}
