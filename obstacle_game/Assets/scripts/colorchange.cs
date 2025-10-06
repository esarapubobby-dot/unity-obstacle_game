using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour
{
    [SerializeField] private MeshRenderer mr;
    [SerializeField] private Color color;

    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        color = mr.material.color;


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mr.material.color = Color.red;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mr.material.color = color;
        }
    }
}
