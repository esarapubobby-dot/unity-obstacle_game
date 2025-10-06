using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallrotate : MonoBehaviour
{
    [SerializeField] private float speed = 100f;


    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
