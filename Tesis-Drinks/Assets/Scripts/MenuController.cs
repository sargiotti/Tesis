using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

	public GameObject prefabAgregar;
	public Transform content;




	public static MenuController MenuINSTANCE;
	void Awake(){
		if (MenuINSTANCE == null) {
			MenuINSTANCE = this;
		}
	}

	public void Instanciar(){
		GameObject clonPrefab = Instantiate (prefabAgregar);
		clonPrefab.transform.SetParent (content);
		clonPrefab.transform.localScale = Vector3.one;
		clonPrefab.transform.localPosition = Vector3.zero;
	}

	public void OnAgregar(GameObject button, InputField CajaTxt){
		if (CajaTxt.text != "") {
			GameController.INSTANCE.Nombres.Add (CajaTxt.text);
			button.SetActive (false);
			CajaTxt.interactable =false;
			Instanciar ();
		} else {
			Debug.Log ("Escribi algo antes forro del orto");
		}
	}





}
