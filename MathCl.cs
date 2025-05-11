using UnityEngine;

public class MathCl : MonoBehaviour
{


    public GameObject objectPrefab;  // The object to instantiate
    public int numberOfObjects = 10; // Number of objects to spawn
    public float radius = 5f;        // Radius of the circle

    private bool hasSpawned = false;  // To make sure instantiation only happens once

    void Start()
    {
        if (!hasSpawned)
        {
            // Only spawn objects once when the scene starts
            SpawnObjectsInCircle(numberOfObjects, radius);
            hasSpawned = true;  // Prevent future spawns
        }
    }

    void SpawnObjectsInCircle(int num, float radius)
    {
        for (int i = 0; i < num; i++)
        {
            // Calculate the angle for this object
            float angle = i * Mathf.PI * 2 / num; // Full circle (2*pi)

            // Calculate the position on the circle
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            Vector3 spawnPos = new Vector3(x, 0, z); // 0 for y (you can adjust this if needed)

            // Instantiate the object at the calculated position with no rotation
            Instantiate(objectPrefab, spawnPos, Quaternion.identity);
        }
    }
}

/* 
   [SerializeField] Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
     void Rotatetarget()
    {
        float Horizontal = target.position.x - transform.position.x;
        float Vertical = target.position.y - transform.position.y;
       float degree = Mathf.Atan2(Vertical, Horizontal) *Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0,degree);
    }
    void MoveOscilating()
    {
        Vector3 postion= transform.position;
        postion.y = Mathf.Sin(Time.time*2)*3;
        transform.position = postion;

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, target.transform.position);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { 
        Rotatetarget();
        }
       MoveOscilating();
        
    }
}

 */
