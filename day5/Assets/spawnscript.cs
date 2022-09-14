using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnscript : MonoBehaviour
{

    public GameObject enemy;
    public float delay;

    //.....??
    public Transform leftspawn;
     public Transform rightspawn;
  


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 0f, delay); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn()
    {
      int  randompos = Random.Range(1, 3);

        if (randompos == 1)
        {
            Instantiate(enemy, leftspawn);

        }
        else if (randompos < 4)
        {
            Instantiate(enemy, transform);
        }
        else {

            Instantiate(enemy, rightspawn);
        }

       // Instantiate(enemy, transform);// remeber to make all 0 to make spawn at 0 point 

    }
}
