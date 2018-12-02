using UnityEngine;

public class RocksEvent : MonoBehaviour {

    public Transform Ship;
    public GameObject Obstacle;

    private int speed = 5;
    private float nextTime2Spawn = 0;
	
	void Update () {
        if (phasing.isSailing) { 
        Vector2 pos = PickPosition();
        //For now---
            if(Time.time > nextTime2Spawn) { 
                for(int i = 0;i<5; i++) { 
                    SpawnRock(pos);
                }
                nextTime2Spawn = Time.time + speed;
            }
        }
    }
    
    Vector2 PickPosition()
    {
        Vector2 pos;
        pos.y = Ship.transform.position.y + 22;
        float x = Random.value * 30 - 15;
        pos.x = x;
        return pos;
    }


    void SpawnRock(Vector2 pos)
    {
        Instantiate(Obstacle, pos, Ship.rotation);
    }
}
