using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flappy : MonoBehaviour
{
    public float jumpSpeed = 4;
    public float speed = 1;
    public int coins = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = GetComponent<Rigidbody>().velocity;
        velocity.x = speed;
        //transform.Translate(Vector3.right*speed*Time.deltaTime);
        if (Input.GetMouseButtonDown(0))
        {
            velocity.y = jumpSpeed;
            //GetComponent<Rigidbody>().AddForce(Vector3.up * 200);
        }
        GetComponent<Rigidbody>().velocity = velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Meta")
        {
            Debug.Log("You win! Coins: "+coins);
            coins = 0;
        }
        else if(collision.gameObject.tag == "Coin")
        {
            coins++;
            Destroy(collision.collider.gameObject);
        }
        else
        {
            Debug.Log("You lose. Your coins: "+coins);
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            transform.position = Vector3.zero;
            coins = 0;
            //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("Scene1", LoadSceneMode.Single);

        }
    }
}
