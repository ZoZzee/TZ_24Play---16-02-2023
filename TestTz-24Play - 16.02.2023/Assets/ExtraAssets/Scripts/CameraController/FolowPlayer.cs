using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolowPlayer : MonoBehaviour
{
    public GameObject player;
    public float distanse;

    void Update()
    {
        this.transform.position = player.transform.position + new Vector3(0,0,distanse);
    }
}
