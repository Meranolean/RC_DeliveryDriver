using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour {
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] float destoryDelay;

    SpriteRenderer spriteRenderer;
    bool hasPackage;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("We collied");
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage) {
            spriteRenderer.color = hasPackageColor;
            Debug.Log("Package picked up!");
            hasPackage = true;
            Destroy(other.gameObject, destoryDelay);
        } else if (other.tag == "Customer" && hasPackage) {
            spriteRenderer.color = noPackageColor;
            Debug.Log("Package Delivered");
            hasPackage = false;
        }
    }
}
