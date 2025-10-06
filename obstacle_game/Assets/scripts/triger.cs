using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triger : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Rigidbody rb1;
    [SerializeField] private Rigidbody rb2;

    public GameObject cube;
    public GameObject cube1;
    public GameObject cube2;


    void Start()
    {
        rb = cube.gameObject.GetComponent<Rigidbody>();
        rb1 = cube1.gameObject.GetComponent<Rigidbody>();
        rb2 = cube2.gameObject.GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb1.useGravity = false;
        rb2.useGravity = false;
        

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rb.useGravity = true;
            rb1.useGravity = true;
            rb2.useGravity = true;
        }
    }
}
