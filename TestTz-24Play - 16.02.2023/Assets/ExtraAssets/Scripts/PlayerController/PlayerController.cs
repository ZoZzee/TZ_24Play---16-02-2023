using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject spawn;
    public GameObject pluseOne;
    public ParticleSystem explosion;
    private GameManager gameManager;
    private float HorizontalInput;
    
    public static float speedRight = 2f;
    public static int Pos = 2;

    private Vector3 spawnPosition;

    private Animator playerAnim;
    

    private float speed = 6.5f;

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        playerAnim = GameObject.Find("Stickman").GetComponent<Animator>();
    }

    void Update()
    {
        if (transform.position.x < -Pos)
        {
            transform.position = new Vector3(-Pos, transform.position.y, transform.position.z);
        }
        else
        {
            if (transform.position.x > Pos)
            {
                transform.position = new Vector3(Pos, transform.position.y, transform.position.z);
            }
        }
        if (GameManager.GameOver == false)
        {
            HorizontalInput = Input.GetAxis("Horizontal");

            transform.Translate(Vector3.right * Time.deltaTime * -HorizontalInput * speedRight);
            transform.Translate(Vector3.back * speed * Time.deltaTime);  
        }
            
    }


    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameManager.GameOver = true;
        }
        if (other.gameObject.CompareTag("Friend"))
        {
            playerAnim.SetTrigger("Jump");
            Destroy(other.gameObject);
            spawnPosition = transform.position;
            transform.Translate(Vector3.up * 1.2f);
            Instantiate(spawn, spawnPosition + new Vector3(0, 0.55f, 0), spawn.transform.rotation);
            Instantiate(pluseOne, spawnPosition + new Vector3(0, 5.5f, 0),new Quaternion (0,0, 0,0));
            explosion.Play();
            gameManager.UpdateScore(1);
        }
    }



}
