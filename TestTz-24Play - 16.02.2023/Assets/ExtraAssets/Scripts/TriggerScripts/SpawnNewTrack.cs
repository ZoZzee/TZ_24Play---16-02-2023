using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewTrack : MonoBehaviour
{

    public GameObject[] track;

    private float numTrac = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (numTrac == 0)
            {
                Vector3 distans = new Vector3(0, -50f, 61.5f);
                int nomberTrack = Random.Range(0, track.Length);
                Instantiate(track[nomberTrack], this.transform.position + distans, transform.rotation);
                Destroy(this.gameObject);
                numTrac++;
            }
        }
    }

}
