using UnityEngine;


public class camerafollow : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, target.position.y, -10);
    }
}