using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movementBehaviour : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    public Object jugador;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0) {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            if(touch.phase == TouchPhase.Stationary) {
                Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit raycastHit;
                //Debug.Log("Soccer Ball clicked");
                if (Physics.Raycast(raycast, out raycastHit)) {
                    if (raycastHit.collider.CompareTag("moveRight")) {
                        Debug.Log("right button clicked");
                        if (transform.position.x < -2.3) {
                            transform.Translate(1 * speed, 0, 0);
                        }

                        
                    } else if (raycastHit.collider.CompareTag("moveLeft")) {
                        if(transform.position.x > -6.1) {
                            transform.Translate(-1 * speed, 0, 0);
                        }
                        

                    }
                }
            }
        }
        



        /*if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                Debug.Log("Something Hit");
                if (raycastHit.collider.name == "Soccer")
                {
                    Debug.Log("Soccer Ball clicked");
                }

                //OR with Tag

                if (raycastHit.collider.CompareTag("moveRight"))
                {
                    Debug.Log("right button clicked");

                }else if (raycastHit.collider.CompareTag("moveLeft"))
                {
                    Debug.Log("left button clicked");
                    
                }
            }
        }*/
    }
}
