using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FusionMonsterMovement : MonoBehaviour
{
    // Update is called once per frame
    [SerializeField] Vector3 dest;
    [SerializeField] float TimeToDest = 1.5f;
    private float xSpeed, zSpeed;
    
    void Start() 
    {
        xSpeed = (dest.x - transform.position.x) / (TimeToDest);
        zSpeed = (dest.z - transform.position.z) / (TimeToDest);
    }

    void Update()
    {
        transform.position = new Vector3(
            transform.position.x + xSpeed * Time.deltaTime,
            transform.position.y,
            transform.position.z + zSpeed * Time.deltaTime
        );

    }
}
