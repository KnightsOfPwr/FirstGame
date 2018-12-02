using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sinkingBar : MonoBehaviour
{

    public Image Bar;


    void Update()
    {
        Bar.fillAmount = ShipVigor.sinking / ShipVigor.maxSinking;
    }
}
