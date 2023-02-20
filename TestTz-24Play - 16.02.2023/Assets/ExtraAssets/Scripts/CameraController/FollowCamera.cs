using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject Player;

    private Vector3 distanse = new Vector3(4f, 6.8f, -12.7f); 

    void Update()
    {
        this.transform.position = Player.transform.position + distanse;
    }
}
