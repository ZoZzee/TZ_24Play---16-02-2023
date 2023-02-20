using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public GameObject spawn;
    public GameObject player;
    public GameObject pluseOne;
    private PlayerController playerControllerScript;
    private Animator playerAnim;
    private GameManager gameManager;
    private bool gameOver = false;

    private float HorizontalInput;

    private Vector3 spawnPosition;
    private float speed = 4f;

    private float timeDesroy = 4;

    void Start()
    {

        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        player = GameObject.Find("Player");
        playerAnim = GameObject.Find("Stickman").GetComponent<Animator>();
    }
    void Update()
    {
        if (gameOver == false)
        {
            this.transform.position = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
        }
        if (gameOver == true)
        {
            Vector3 on = this .transform.position;
            this.transform.position = on;
            if (GameManager.GameOver == false)
            {
                timeDesroy -= Time.deltaTime;
                if (timeDesroy < 0)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            gameOver = true;
        }
        if (other.gameObject.CompareTag("Friend"))
        {
            Destroy(other.gameObject);
            spawnPosition = transform.position;
            playerControllerScript.transform.Translate(Vector3.up * 1.2f);
            playerAnim.SetTrigger("Jump");
            transform.Translate(Vector3.up * 1.5f);
            playerControllerScript.explosion.Play();
            Instantiate(pluseOne, spawnPosition + new Vector3(0, 5.5f, 0), new Quaternion(0, 0, 0, 0));
            Instantiate(spawn, spawnPosition, spawn.transform.rotation);

            gameManager.UpdateScore(1);
        }
    }
}
