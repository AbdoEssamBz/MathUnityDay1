using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    

    [SerializeField] float speed = 2f;
    private float range = 20f; 

    void Update()
    {
       
        float x = Mathf.PingPong(Time.time * speed, range) - range / 2f;
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}
