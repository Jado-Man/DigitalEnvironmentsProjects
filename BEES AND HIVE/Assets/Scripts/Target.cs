using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public float odds = 0.01f;
    public float newRange = 4f;
    public float speed = 0.01f;
    
    Vector3 newTarget = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0f, 1f) < odds) {
            float x = Random.Range(-newRange, newRange);
            float y = Random.Range(-newRange, newRange);
            float z = Random.Range(-newRange, newRange);
            newTarget = new Vector3(x, y, z);
        }

        transform.position = Vector3.Lerp(transform.position, newTarget, speed);
    }
}
