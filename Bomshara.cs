using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomshara : MonoBehaviour
{
    public int health = 5; 

    public int level = 1;

    public float speed = 1.2f; 
    void Start ()
    {
        health += level;

    }
    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;



    }
}
