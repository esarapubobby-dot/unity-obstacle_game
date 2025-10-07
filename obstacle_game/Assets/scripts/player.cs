using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private float speed=20f;
    private Rigidbody playerRb;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.freezeRotation = true;
    }

    void Update()
    {
        float xvalue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float zvalue = Input.GetAxis("Vertical") * speed * Time.deltaTime;


        transform.Translate(xvalue, 0, zvalue);

    }
}
