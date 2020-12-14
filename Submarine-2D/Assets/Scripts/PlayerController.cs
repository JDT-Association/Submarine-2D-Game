using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    public Joystick joystick;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(joystick.Horizontal, joystick.Vertical, 0) * Time.deltaTime * 5);
        
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.setHealth(currentHealth);
}

    private void OnCollisionEnter2D(Collision2D other){
        print("Le pegastes wey");
        if (other.gameObject.tag == "Enemy")
        {
            //Destroy(other.gameObject);
            TakeDamage(10);
            print("Vida: "+currentHealth);
        }
    }
}

