using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipVigor : MonoBehaviour {

    public static float shipHealth, MaxShipHealth = 100;
    public static float box = 20, sinking, maxSinking = 1000;
    public float mEngineer = 70, engineerFactor = 1, mBox = 10;
    public float mWorker = 85, workerFactor = 1;
    public float massSinkingFactor = 1;
    public static int worker = 15, engineer = 8;
    public float starvationPeriod = 5;
    private float time2Die = 0;
    public float mass;


    void Start () {
        shipHealth = MaxShipHealth;
        sinking = maxSinking;
	}
	
	// Update is called once per frame
	void Update () {
        mass = mWorker + mEngineer + mBox + 0; //Captains do not weight on the ship!
        sinking-=(MaxShipHealth - shipHealth)*(box*mBox+engineer*mEngineer+worker*mWorker)*massSinkingFactor;
        shipHealth= (shipHealth + engineer* engineerFactor);
        box += worker * workerFactor;

        if(shipHealth > MaxShipHealth) { shipHealth = MaxShipHealth; }

        if (box < 1)
        {
            if(Time.time > time2Die)
            {
                if(Random.value > 0.5f)
                {
                    engineer--;
                    //TODO
                }
                else
                {
                    worker--;
                    //TODO
                }
                time2Die = Time.time + starvationPeriod + Random.value*2-1;
            }
        }
        
        if(sinking < 0)
        {
            Debug.Log("GameOver");
            //GAMEOVEAEAR();
        }
		
	}
}
