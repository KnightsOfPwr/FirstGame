using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamaraEnter : MonoBehaviour {
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CaptainControl captain = collision.GetComponent<CaptainControl>();
        if( captain != null )
        {
            phasing.isSailing = true;
        }
    }


}
