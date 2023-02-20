using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObgect : MonoBehaviour
{
    public float m_Time = 4;   

    void Update()
    {
        m_Time=m_Time-Time.deltaTime;
        if(m_Time < 0)
        {
            Destroy(gameObject);
        }
    }
}
