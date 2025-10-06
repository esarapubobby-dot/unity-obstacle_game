using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private float speed=20f;

    void Update()
    {
        float xvalue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float zvalue = Input.GetAxis("Vertical") * speed * Time.deltaTime;


        transform.Translate(xvalue, 0, zvalue);

    }
}
