using UnityEngine;

public class RocksEvent : MonoBehaviour {

    public Transform Ship;
    public GameObject Obstacle;

    private int speed = 5;
    private float nextTime2Spawn = 0;
	
	void Update () {
        if (phasing.isSailing) {
            Vector2 pos;

            //For now---
            if (Time.time > nextTime2Spawn) { 
                pos = PickPosition();
                SpawnRock(pos);
                nextTime2Spawn = Time.time + 0.25f+Random.value*0.5f;
            }
        }
    }
    
    Vector2 PickPosition()
    {
        Vector2 pos;
        pos.y = Ship.transform.position.y + 35;
        float x = Random.value * 30 - 15f;
        pos.x = x;
        return pos;
    }


    void SpawnRock(Vector2 pos)
    {
        Instantiate(Obstacle, pos, Ship.rotation);
    }
}
