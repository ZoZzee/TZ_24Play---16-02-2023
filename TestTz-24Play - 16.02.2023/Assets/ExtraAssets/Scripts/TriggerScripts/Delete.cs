using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Friend"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Untagged"))
        {
            Destroy(collision.gameObject);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Friend"))
        {
            Destroy(other.gameObject);
        }

    }
}
