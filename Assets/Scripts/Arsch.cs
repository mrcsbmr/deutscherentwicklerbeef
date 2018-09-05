using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arsch : MonoBehaviour {

    public Scheisse Wurst;
    public float Velocity = 1f;
    public float CoyoteTimer = 0;
    public float minX, maxX;

    public AudioSource hnngSound;


    private Transform cTransform;
    private Animator cAnimator;
    private bool ready = true;

    

    private void Start()
    {
        cTransform = transform;
        cAnimator = GetComponent<Animator>();

        Cursor.lockState = CursorLockMode.Confined;

        transform.position = new Vector3(-0.09f, 4.79f, -0.12f);
    }


    void Update ()
    {
        if (ready && CoyoteTimer > 0)
        {
            CoyoteTimer -= Time.deltaTime;
        }

        if (Input.GetMouseButton(0))
        {
         
            if (CoyoteTimer <= 0)
            {
                cAnimator.SetBool("abdruecken", true);

                if (!hnngSound.isPlaying)
                    hnngSound.Play();

                
                    Wurst.Feuer();
            }
        }
        else if (ready && (Input.GetAxis("Mouse X") > 0 && transform.position.x <= maxX || Input.GetAxis("Mouse X") < 0 && transform.position.x >= minX))
        {
            transform.position = new Vector3(cTransform.position.x + Input.GetAxis("Mouse X") * Velocity * Time.deltaTime, cTransform.position.y, cTransform.position.z);
        }
        else
        {
            cAnimator.SetBool("abdruecken", false);
        }
        
    
    }

    public void AssWait()
    {
        CoyoteTimer = 1f;
        ready = false;
    }

    public void ReadyAss()
    {
        ready = true;
    }
}
