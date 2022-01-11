using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using System;

public class Driver : MonoBehaviour {
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.01f;
    void Start() {
    }

    void Update() {
        float steerAmount = Input.GetAxisRaw("Horizontal") * steerSpeed * Time.deltaTime;
        // if (System.Math.Abs(Input.GetAxis("Horizontal")) != 1) {
        //     steerAmount = 0;
        // }
        transform.Rotate(0, 0, - steerAmount);
        float moveAmount = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
        // if (System.Math.Abs(Input.GetAxis("Vertical")) != 1) {
        //     moveAmount = 0;
        // }
        // Debug.Log(Input.GetAxis("Vertical"));

        transform.Translate(0, moveAmount, 0);
    }
}
