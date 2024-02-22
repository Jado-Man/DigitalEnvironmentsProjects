using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public Transform target;
    public float speed = 0.01f;
    public float shake = 0.03f;

    // Update is called once per frame
    void Update()
    {
        // Move towards the target position
        transform.position = Vector3.Lerp(transform.position, target.position, speed);

        // Calculate the direction vector between current position and target position
        Vector3 direction = (target.position - transform.position).normalized;

        // Face the direction the creature is moving in
        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }

        // Add random shake
        float x = Random.Range(-shake, shake);
        float y = Random.Range(-shake, shake);
        float z = Random.Range(-shake, shake);
        transform.Translate(x, y, z);
    }
}
