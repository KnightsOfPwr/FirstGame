using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heathbarFill : MonoBehaviour {

    public Image Bar;

    
	void Update () {
        Bar.fillAmount = ShipVigor.shipHealth / ShipVigor.MaxShipHealth;
	}
}
