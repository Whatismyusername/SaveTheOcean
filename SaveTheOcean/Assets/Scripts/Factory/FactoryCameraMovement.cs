using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryCameraMovement : MonoBehaviour
{

    [SerializeField] float yDest = -5f;
    private float startingYPos;
    private float startingTime;
    // Start is called before the first frame update
    void Start()
    {
        startingYPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > yDest) {
            float yPos = startingYPos - Time.timeSinceLevelLoad * 8f;
            transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
        }
    }
}
