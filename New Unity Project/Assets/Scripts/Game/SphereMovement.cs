using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    Vector3 startingPos;
    [SerializeField] float movementSpeed = 1f;
    [SerializeField] float zMovement = 5f;
    [SerializeField] float delay;
    float offset;
    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        offset = Mathf.Sin(Time.time - delay) * movementSpeed * zMovement;
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, startingPos.z + offset);
    }
}
