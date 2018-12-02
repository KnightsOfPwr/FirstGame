using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class phasing : MonoBehaviour {
    public static bool isSailing = true;
    public GameObject sailingCamera;

    public Rigidbody2D ship;
    public Rigidbody2D reis;
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Tab) && isSailing)
        {
            isSailing = false;
        }
        if(isSailing)
        {
            sailingCamera.GetComponent<CinemachineVirtualCamera>().Priority = 20;
        }else
        {
            reis.isKinematic = false;
            sailingCamera.GetComponent<CinemachineVirtualCamera>().Priority = 10;
        }
    }
}
