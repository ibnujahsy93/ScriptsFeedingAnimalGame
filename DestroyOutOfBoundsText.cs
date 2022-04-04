using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsText : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If Object goes past player view in game, destroy object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}