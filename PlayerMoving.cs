using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public Transform enemy;
    public float detectionDistance = 5f;
    public float detectionThreshold = 0.866f; // Cos(30 degrees)

    void Update()
    {
        Vector2 toEnemy = (enemy.position - transform.position);
        float distance = toEnemy.magnitude;

        if (distance > detectionDistance)
            return;

       
        float angleRad = transform.eulerAngles.z * Mathf.Deg2Rad;
        Vector2 playerForward = new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad));

        Vector2 toEnemyDir = toEnemy.normalized;

        float dot = Vector2.Dot(playerForward, toEnemyDir);

        if (dot > detectionThreshold)
        {
            Debug.Log("Enemy is Detected");
        }
    }
}

