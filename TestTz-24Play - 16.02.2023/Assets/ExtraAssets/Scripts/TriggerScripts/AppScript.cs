using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppScript : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        if (transform.position.y <= 0)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (transform.position.y != 0 && transform.position.y < -1)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }
}
