using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float movementSpeed = 10f;
    [SerializeField] float xRange = 20f;
    [SerializeField] float yRange = 3.7f;

    [Header("Rotation")]
    [SerializeField] float rollTransformFactor = -4.5f;
    [SerializeField] float yawTransformFactor = 4f;
    [SerializeField] float pitchFactor = -50f;
    [SerializeField] float rollControlFactor = -30f;

    [Header("Weapons")]
    [SerializeField] GameObject[] guns;
    private float xThrow;
    private float yThrow;
    private bool isAlive = true;

    
    // Update is called once per frame
    void Update()
    {
        if(isAlive) {
            OnPlayerInput();
            RotateShip();
            ProcessFiring();
        } else {
            ActivateGuns(false);
        }
    }

    void StartDeathSequence() {
        isAlive = false;
    }

    private void OnPlayerInput() {
        xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xPosRaw = transform.localPosition.x + xThrow * movementSpeed * Time.deltaTime;
        float xPos = Mathf.Clamp(xPosRaw, -xRange, xRange);

        yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float yPosRaw = transform.localPosition.y + yThrow * movementSpeed * Time.deltaTime;
        float yPos = Mathf.Clamp(yPosRaw, -yRange, yRange);

        transform.localPosition = new Vector3(xPos, yPos, transform.localPosition.z);
    }

    private void RotateShip() {
        float rollDueToTransform = transform.localPosition.y * rollTransformFactor;
        float rollDueToControl = yThrow * rollControlFactor;
        
        float roll = rollDueToTransform + rollDueToControl;

        float yaw = transform.localPosition.x * yawTransformFactor;

        float pitch = xThrow * pitchFactor;
        transform.localRotation = Quaternion.Euler(roll, yaw, pitch);
    }

    private void ProcessFiring() {
        if(CrossPlatformInputManager.GetButton("Fire")) {
            ActivateGuns(true);
        } else {
            ActivateGuns(false);
        }
    }

    private void ActivateGuns(bool option) {
        foreach (GameObject gun in guns) {
            gun.SetActive(option);
        }
    }
}
