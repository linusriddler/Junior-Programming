using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private Rigidbody playerRb2;
    private float speed2 = 500;
    private GameObject focalPoint2;

    void Start()
    {
        playerRb2 = GetComponent<Rigidbody>();
        focalPoint2 = GameObject.Find("Focal Point");
    }

    void Update()
    {
        // Add force to player to move Vertically
        float verticalInput = Input.GetAxis("Vertical");
        playerRb2.AddForce(focalPoint2.transform.forward * verticalInput * speed2 * Time.deltaTime);
        // Add force to player to move horizontally
        float verticalInput = Input.GetAxis("Vertical");
        playerRb2.AddForce(focalPoint2.transform.forward * verticalInput * speed2 * Time.deltaTime);
    }
}
