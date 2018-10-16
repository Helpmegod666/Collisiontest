using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    //rbody.addforce    
    //xxx.addrelativeforce
    //xxx.addtorque
    //xxx.moveposition / moverotation
    //xxx.velocity

    public Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    
    //lägg fysikskit här asså
    void FixedUpdate()
    {
        //if ska egentligen användas här om man inte callar på den med en variabel

        if (Input.GetKey(KeyCode.D))
        {
        rbody.AddForce(new Vector2(10f, 0f));
        }

        if (Input.GetKey(KeyCode.A))
        {
            rbody.AddForce(new Vector2(-10f, 0f));
        }

        if (Input.GetKey(KeyCode.W))
        {
            rbody.AddForce(new Vector2(0f, 10f));
        }

        if (Input.GetKey(KeyCode.S))
        {
            rbody.AddForce(new Vector2(0f, -10f));
        }
    }

    private void OnCollisionEnter2D(Collision2D colln)
    {
        //man kan ha en gameover scene fast jag är deppig och vill inte just nu
        SceneManager.LoadScene("SampleScene");
    }
}
