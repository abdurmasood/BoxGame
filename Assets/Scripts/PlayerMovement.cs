using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed;
    private float maxSpeed = 5f;

    public Rigidbody rb;

    private Vector3 input;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    void Update() {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * moveSpeed;

        //check if the velocity of the body is less than max speed and if it is add external force to it
        if (rb.velocity.magnitude < maxSpeed) {
            rb.AddForce(input * moveSpeed);
        }
    }
}
