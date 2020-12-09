using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Joystick joystick;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(joystick.Horizontal, joystick.Vertical, 0) * Time.deltaTime * 5);
     
    }
}
