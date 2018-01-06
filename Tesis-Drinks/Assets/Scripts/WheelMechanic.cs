using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelMechanic : MonoBehaviour {

    public RectTransform Wheel;
    public RectTransform Arrow;
    public float wheelRotationSpeed = 20f;


    public int spinningRotation = 1;
    public int tapsLeft = 1;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (tapsLeft > 1)
        {
            Wheel.Rotate(0, 0, wheelRotationSpeed * spinningRotation * Time.deltaTime);
        }
    }

    public void onWheelTap()
    {
        Debug.Log("se toco la rueda");
        //tapsLeft--;
    }
}
