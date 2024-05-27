using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codRobot : MonoBehaviour
{
    public float vel = 1;
    private Rigidbody2D rb;
    public AudioClip salto;
    public AudioClip explosion;

    //parte de perder
    public codEscena codescena;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity=Vector2.up*vel;
            Camera.main.GetComponent<AudioSource>().PlayOneShot(salto);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        codescena.Perdiste();
        Camera.main.GetComponent<AudioSource>().Stop();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(explosion);
    }
}
