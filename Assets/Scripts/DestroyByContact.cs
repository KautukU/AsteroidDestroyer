using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public int scoreValue = 10;

    

    private GameController gameControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        GameObject GameControllerObject = GameObject.FindWithTag("GameController");

        if (GameControllerObject != null)
        {
            // I got the game controller object!!
            gameControllerScript = GameControllerObject.GetComponent<GameController>();
        }
        if (GameControllerObject == null)
        {
            Debug.Log("IT didn't work");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // instantiate explosion and position it
        Instantiate(explosion, this.transform.position, this.transform.rotation);


        if (other.gameObject.CompareTag("Player"))
        {
            // Collided with the player object
            gameControllerScript.GameOver();
        }
        else
        {
            gameControllerScript.AddScore(scoreValue);
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }

    
}
