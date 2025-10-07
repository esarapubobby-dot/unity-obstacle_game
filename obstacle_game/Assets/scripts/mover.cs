using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{   
    private float speed=20f;
    void Update()
    {
        float jumb = Input.GetAxis("Jump");
        transform.Translate(0, jumb* speed * Time.deltaTime, 0);
    }
}
