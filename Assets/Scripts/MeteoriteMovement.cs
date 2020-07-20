using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteMovement : MonoBehaviour
{
    public float minMov = -10f;
    public float maxMov = 10f;
    public int deleteSec = 10;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = RandomVector(minMov, maxMov);
        Destroy(gameObject, deleteSec);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 RandomVector(float min, float max)
    {
        float x = Random.Range(min, max);
        float y = Random.Range(min, max);
        return new Vector3(x, y, 0);
    }
}
