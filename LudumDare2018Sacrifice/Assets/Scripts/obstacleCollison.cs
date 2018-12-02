using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleCollison : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        spawnCrew s = collision.GetComponent<spawnCrew>();

        if(s!=null)
        {
            ShipVigor.shipHealth -= 0.2f;
        }

    }
}
