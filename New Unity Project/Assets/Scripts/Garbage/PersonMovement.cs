using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMovement : MonoBehaviour
{

    private Animation animation;
    private float startingZPos;
    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
        startingZPos = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        StartRunning();
    }

    private void StartRunning() {
        animation.enabled = true;
        offset = Time.time;
        transform.position = new Vector3(transform.position.x, transform.position.y, startingZPos - offset);
    }
}
