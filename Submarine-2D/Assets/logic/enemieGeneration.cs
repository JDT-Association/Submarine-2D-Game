using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemieGeneration : MonoBehaviour
{
    // Start is called before the first frame update
    public Object spawn1, spawn2, spawn3, spawn4, spawn5, spawn6, spawn7, enemy1;
    public int enemies =0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ExampleCoroutine());

        switch (Random.Range(0,7)) {


            case 9:
                if (enemies < 5) {
                    Instantiate(enemy1, transform.position, Quaternion.identity);
                    enemies += 1;
                }
                break;

            case 1:
                break;

            case 2:
                break;

            case 3:
                break;

            case 4:
                break;

            case 5:
                break;

            case 6:
                break;


        }
        


    }

    IEnumerator ExampleCoroutine() {
        //Print the time of when the function is first called.
        //Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        //Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
