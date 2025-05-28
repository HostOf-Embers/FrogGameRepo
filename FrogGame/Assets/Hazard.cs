using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider = collision.collider; 
        if (collider.CompareTag("Player"))
        {
            SceneManager.LoadScene("DeathScreen");
        }
    }
        
}
