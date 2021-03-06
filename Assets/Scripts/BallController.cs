using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public bool ballLaunched = false;
    public Rigidbody2D ballRigidbody;
    public Vector2[] startDirections;
    public int randomNum;
    public float ballForce;
    public Vector3 startPosition;

    public GameMaster gameMaster;

    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody2D>();
        gameMaster.GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !ballLaunched)
        {
            randomNum = Random.Range(0, startDirections.Length);
            ballRigidbody.AddForce(startDirections[randomNum] * ballForce, ForceMode2D.Impulse);
            ballLaunched = true;
        } 

        if (Input.GetKeyDown(KeyCode.R))
        {
            ballRigidbody.velocity = Vector3.zero;
            transform.position = startPosition;
            ballLaunched = false;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "DefeatZone")
        {
            gameMaster.playerLives = gameMaster.playerLives - 1;
            ballRigidbody.velocity = Vector3.zero;
            transform.position = startPosition;
            ballLaunched = false;
        }
    }

}
