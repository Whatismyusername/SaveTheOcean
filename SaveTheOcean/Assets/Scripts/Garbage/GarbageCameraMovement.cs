using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCameraMovement : MonoBehaviour
{
    private Transform colaTrans;
    private float xRotateDest = 40f;
    private float yRotateDest = 0f;
    private float xRotate, yRotate;
    [SerializeField] float xRotateSpeed = 10f;
    [SerializeField] float yRotateSpeed = 70f;

    private bool firstRotationCompleted = false;
    private float startingTime;
    // Start is called before the first frame update
    void Start()
    {
        colaTrans = GameObject.Find("Cola").transform;
    }

    // Update is called once per frame
    void Update()
    {
        FirstRotation();
        if(firstRotationCompleted) {
            Invoke("SecondRotation", 1f);
        }
    }

    void FirstRotation() {
        if (!firstRotationCompleted) {

            // X
            if(transform.rotation.eulerAngles.x < xRotateDest) {
                xRotate = transform.rotation.eulerAngles.x + xRotateSpeed * Time.deltaTime;
            } 

            
            // Y
            if(transform.rotation.y > yRotateDest) {
                yRotate = transform.rotation.eulerAngles.y - yRotateSpeed * Time.deltaTime;
            }
            
            transform.rotation = Quaternion.Euler(xRotate, yRotate, 0f);

            // If done
            if (transform.rotation.eulerAngles.x >= xRotateDest && transform.rotation.y <= yRotateDest) {
                firstRotationCompleted = true;
            }
        }
    }

    void SecondRotation() {
        
        if(transform.rotation.eulerAngles.x > 10f) {
            xRotate = transform.rotation.eulerAngles.x - xRotateSpeed * Time.deltaTime;
        }

        transform.rotation = Quaternion.Euler(xRotate, transform.rotation.eulerAngles.y, 0f);
    }
}
