using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipVigor : MonoBehaviour {


    public static float shipHealth, MaxShipHealth = 10;
    public static float box = 20, sinking, maxSinking = 100000;
    public static int worker = 15, engineer = 8;

    public float workerEat = 1, engineerEat = 1;
    public float mEngineer = 7, engineerFactor = 0.0001f, mBox = 1;
    public float mWorker = 8, workerFactor = 1;
    public float massSinkingFactor = 1;
    public float starvationPeriod = 5;

    private float time2Die = 0;
    private float mass;


    void Start () {
        shipHealth = MaxShipHealth;
        sinking = 0;
	}
	
	// Update is called once per frame
	void Update () {
        mass = mWorker*worker + mEngineer*engineer + box*mBox + 0; //Captains do not weight on the ship!
        sinking+=(MaxShipHealth - shipHealth)*mass*massSinkingFactor;
        shipHealth= (shipHealth + engineer* engineerFactor);
        box += worker * workerFactor;
        box -= worker * workerEat + engineer * engineerEat;
        Debug.Log("sinking = " + sinking + "\nshiphealth= " + shipHealth +
            "\nEngineer: " + engineer + " worker: " + worker);
        if(shipHealth > MaxShipHealth) { shipHealth = MaxShipHealth; }
        if (worker < 0) { worker = 0; }
        if (box < 0) { box = 0; }
        if (engineer < 0) { engineer = 0; }
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
