using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class bird : MonoBehaviour
{
   public Rigidbody2D rb2;
    public float velocity = 1f;
    public Boolean isDead;
    public GameManager manager;
    public GameObject deathScreen;
    public AudioSource audio;
 




    void Start()
    {
        Time.timeScale = 1;

        
        audio.Play();

    }

   
    void Update()
    {
       

        if (Input.GetMouseButtonDown(0) )
        {
          rb2.velocity=Vector2.up*velocity;

        }
   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name=="scoreArea")
        {
            manager.UpdateScore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;
            deathScreen.SetActive(true);
            audio.Pause();
             
        }
    }
}
