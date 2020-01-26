using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanMovement : MonoBehaviour
{
    private Rigidbody rigidbody;
    private bool addedForce = false;
    private bool freezed = false;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!addedForce){
            rigidbody.AddForce(0f, 0f, 100f);
            addedForce = true;
        } 

        if(transform.position.y < -1.054 && ! freezed) {
            rigidbody.velocity = new Vector3 (0, 0, 0);
            freezed = true;
        }
    }
}
