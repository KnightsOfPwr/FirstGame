using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class phasing : MonoBehaviour {
    public static bool isSailing = true;
    public GameObject sailingCamera;
    bool change = false;

    public Rigidbody2D ship;
    public Rigidbody2D reis;
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Tab) && isSailing)
        {
            isSailing = false;
            change = true;
        }
        if(isSailing)
        {
            reis.isKinematic = true;
            Vector2 pos = ship.position;
            pos.y -= 0.5f;
            reis.position = pos;
            sailingCamera.GetComponent<CinemachineVirtualCamera>().Priority = 20;
        }else
        {
            if (change) { 
                Vector2 pos = ship.position;
                pos.y -= 1.4f;
                change = false;
                reis.position = pos;


                destroyColliders();


            }
            reis.isKinematic = false;
            sailingCamera.GetComponent<CinemachineVirtualCamera>().Priority = 10;
        }
    }

    void destroyColliders()
    {
        GameObject [] l = GameObject.FindGameObjectsWithTag("collider");

        foreach (GameObject col in l)
        {
            Destroy(col);
        }

    }
}
