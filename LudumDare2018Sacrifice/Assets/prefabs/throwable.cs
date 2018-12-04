using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwable : MonoBehaviour {

    public bool isheld;
    public Rigidbody2D capt;

    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	    if(isheld)
        {
            transform.position = capt.position;
        }
	}
}
