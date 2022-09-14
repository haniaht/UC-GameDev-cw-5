using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class player : MonoBehaviour
{

    public float inc;
    public Transform minx;
    public Transform maxx;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move(); 
    }

    private void move()
    {
        if (Input.GetKeyDown(KeyCode.D))
        { //chec if the player pressed d
           //      transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx.position.x,maxx.position.x) + inc, transform.position.y, transform.position.z);

          transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z + inc, minx.position.z, maxx.position.z));
        }
        else if (Input.GetKeyDown(KeyCode.A)) {
         //          transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx.position.x, maxx.position.x) - inc, transform.position.y, transform.position.z);

            transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z- inc, minx.position.z, maxx.position.z) );

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy") {
            SceneManager.LoadScene(0);
        }


    } 
}
