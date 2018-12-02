using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCrew : MonoBehaviour {

    public GameObject box;
    public GameObject engineer;
    public GameObject worker;


    void Start () {
        for(int i= 0; i< ShipVigor.box; i++)
        {
            Vector2 pos;
            pos.x = transform.position.x + Random.value * 2 - 1f;
            pos.y = transform.position.y + Random.value;
            GameObject o = Instantiate(box, pos, transform.rotation);
            o.transform.parent = gameObject.transform;
        }
        for (int i = 0; i < ShipVigor.engineer; i++)
        {
            Vector2 pos;
            pos.x = transform.position.x + Random.value * 2 - 1f;
            pos.y = transform.position.y + Random.value;
            GameObject o = Instantiate(engineer, pos, transform.rotation);
            o.transform.parent = gameObject.transform;
        }
        for (int i = 0; i < ShipVigor.worker; i++)
        {
            Vector2 pos;
            pos.x = transform.position.x + Random.value*2 - 1f;
            pos.y = transform.position.y + Random.value;
            GameObject o = Instantiate(worker, pos, transform.rotation);
            o.transform.parent = gameObject.transform;
        }

    }
	
	void Update () {
		
	}
}
