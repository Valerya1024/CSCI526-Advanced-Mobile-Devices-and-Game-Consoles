using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed;
    private float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        speed = 20;
        rotationSpeed = 80;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime * verticalInput);
    }
}
