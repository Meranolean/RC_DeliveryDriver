using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using System;

public class Driver : MonoBehaviour {
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    void Start() {
    }

    void Update() {
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
        float steerAmount = Input.GetAxisRaw("Horizontal") * steerSpeed * Time.deltaTime;
        if (moveAmount < 0) {
            steerAmount = -steerAmount;
        }
        transform.Rotate(0, 0, - steerAmount);
    }

    void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;    
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Boost") {
            moveSpeed = boostSpeed;
        }
    }
}
