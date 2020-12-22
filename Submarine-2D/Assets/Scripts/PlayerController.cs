using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public int speed = 5;
    public int maxScore = 100;
    public int currentScore;

    public Text scoreText;

    public HealthBar healthBar;
    //public Experience experience;
    public Joystick joystick;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //JoyStickMovement();
        ClickMovement();
        
    }

    void ClickMovement()
    {
        // ejecutar únicamente si existe un touch del usuario en la pantalla
        if (Input.touchCount > 0)
        {
            
            Camera cam = Camera.main;
            // obtenemos la dirección del punto donde tocó el usuario en torno a la cámara
            Vector2 direction = cam.ScreenToWorldPoint(Input.GetTouch(0).position);
            // para no sobrecargar de movimiento/animación, si ya estamos prácticamente encima del punto no se realizará movimiento alguno
            if (Vector3.Distance(direction, transform.position) > 0.2f)
            {
                //caso contrario de que estemos alejados, nos movemos en X & Y hacia ese punto
                transform.position = Vector2.MoveTowards(transform.position, direction, speed * Time.deltaTime);
            }
            
        }
        

    }

    void JoyStickMovement()
    {
        // Movimiento en X & Y según el input detectado en el joystick
        transform.Translate(new Vector3(joystick.Horizontal, joystick.Vertical, 0) * Time.deltaTime * 5);
    }

    
    void TakeDamage(int damage)
    {
        //disminuye la vida dependiendo del daño causado y se actualiza la barra de vida
        currentHealth -= damage;
        healthBar.setHealth(currentHealth);
    }

    void AddScore(int score)
    {
        // aumenta el score dependiendo el numero que le pases
        currentScore += score;
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Le pegastes wey");
        //cuando entra en colission con algun objeto que tenga de tag "Enemy"
        if (collision.gameObject.tag == "Enemy")
        {
            // lo que se hace cuando entra en collision
            TakeDamage(10);
            AddScore(5);
            scoreText.text = currentScore.ToString();
            print("Vida: " + currentHealth);
            print("Score: " + currentScore);
        }
    }

}

