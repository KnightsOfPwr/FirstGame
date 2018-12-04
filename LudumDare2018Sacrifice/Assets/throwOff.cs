using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwOff : MonoBehaviour {

    public float throwRadi;
    private float min;
    public GameObject closest;

	void Update () {

        if(!phasing.isSailing && Input.GetKeyDown(KeyCode.Space))
        {
            min = Vector2.Distance(spawnCrew.Crew[0].transform.position, transform.position);
            closest = spawnCrew.Crew[0];
            foreach (GameObject mem in spawnCrew.Crew)
            {
                float dis = Vector2.Distance(transform.position, mem.GetComponent<GameObject>().transform.position);
                
                if (dis < min)
                {
                    min = dis;
                    closest = mem;
                }
            }
            if (min < throwRadi)
            {

            }
        }
		
	}
}
