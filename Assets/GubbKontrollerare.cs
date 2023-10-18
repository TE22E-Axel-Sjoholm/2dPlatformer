using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GubbKontrollerare : MonoBehaviour
{
    [SerializeField]
    float speed = 4.1f;

    private Rigidbody2D rb;
    public float jumpForce = 12;
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        Vector2 movement = new Vector2(move, 0);
        transform.Translate(movement* speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump"))
        {
            Vector2 jumpVector = new Vector2(rb.velocity.x, jumpForce);
            rb.AddForce(jumpVector, ForceMode2D.Impulse);
        }
    }
}
