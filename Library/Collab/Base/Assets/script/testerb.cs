using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class testerb : MonoBehaviour
{

    private float HorizontalForce;
    private float VerticalForce;
    
    private Rigidbody rb;
    private Collider cl;

    private Animator anim;

    private bool saut_joueur = false;
    private int compteur = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cl = GetComponent<Collider>();
        anim = GetComponent<Animator>();

        HorizontalForce = 0;
        VerticalForce = 0;
        name = this.tag;
     
    }

    // Update is called once per frame
    void Update()
    {
           
        if (name == "player1")
        {
            if (Input.GetKey("d"))
            {
                anim.SetBool("avance", true);
                if (rb.position.y > 2)
                {
                    HorizontalForce = -60;
                }
                else {HorizontalForce = -30;}
                //rb.AddRelativeForce (new Vector3(-HorizontalForce, 0, 0));
                rb.velocity = new Vector3(HorizontalForce,VerticalForce,0);
            }
            else if (Input.GetKey("q"))
            {
                 anim.SetBool("recule", true);
                if (rb.position.y > 2)
                {
                    HorizontalForce = 60;
                }
                else {HorizontalForce = 30;}
                //rb.AddRelativeForce (new Vector3(HorizontalForce, 0, 0));
                rb.velocity = new Vector3(HorizontalForce,VerticalForce,0);
            }
            else 
            {
                HorizontalForce = 0;
                rb.velocity = new Vector3(HorizontalForce,VerticalForce,0);
            }

            if (Input.GetKey("s"))
            {
                anim.SetBool("bas", true);
                rb.velocity = new Vector3(0,0,0);
            }
            if (Input.GetKeyUp("s"))
            {
                anim.SetBool("bas", false);
            }
            if (Input.GetKey("z"))
            {
                anim.SetBool("saut", true);
                saut_joueur = true;
            }
            if (Input.GetKeyUp("z"))
            {
                anim.SetBool("saut", false);
            }
            if (Input.GetKeyUp("d"))
            {
                anim.SetBool("avance", false);
            }
            if (Input.GetKeyUp("q"))
            {
                anim.SetBool("recule", false);
            }
            if (Input.GetKeyDown("g"))
            {
                anim.SetBool("poing", true);
            }
            if (Input.GetKeyUp("g"))
            {
                anim.SetBool("poing", false);
            }
            if (Input.GetKeyDown("h"))
            {
                anim.SetBool("pied", true);
            }
            if (Input.GetKeyUp("h"))
            {
                anim.SetBool("pied", false);
            }
            if (Input.GetKeyDown("t"))
            {
                anim.SetBool("poing2", true);
            }
            if (Input.GetKeyUp("t"))
            {
                anim.SetBool("poing2", false);
            }
            if (Input.GetKeyDown("y"))
            {
                anim.SetBool("pied2", true);
            }
            if (Input.GetKeyUp("y"))
            {
                anim.SetBool("pied2", false);
            }
            
            /*if (Input.GetKey("z"))
            {
                saut_joueur = true;
            }*/
        }

        if (name == "player2")
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                anim.SetBool("recule", true);
                if (rb.position.y > 2)
                {
                    HorizontalForce = -60;
                }
                else {HorizontalForce = -30;}
                rb.velocity = new Vector3(HorizontalForce,VerticalForce,0);
            }
            else if(Input.GetKey(KeyCode.LeftArrow))
            {
                anim.SetBool("avance", true);
                if (rb.position.y > 2)
                {
                    HorizontalForce = 60;
                }
                else {HorizontalForce = 30;}
                rb.velocity = new Vector3(HorizontalForce,VerticalForce,0);
            }
            else 
            {
                HorizontalForce = 0;
                rb.velocity = new Vector3(HorizontalForce,VerticalForce,0);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                anim.SetBool("bas", true);
                rb.velocity = new Vector3(0,0,0);
            }
            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                anim.SetBool("bas", false);
            }
              if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                anim.SetBool("avance", false);
            }
             if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                anim.SetBool("recule", false);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                saut_joueur = true;
                anim.SetBool("saut", true);
            }
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                anim.SetBool("saut", false);
            }
            if (Input.GetKeyDown(KeyCode.Keypad4))
            {
                anim.SetBool("poing", true);
            }
            if (Input.GetKeyUp(KeyCode.Keypad4))
            {
                anim.SetBool("poing", false);
            }
            if (Input.GetKeyDown(KeyCode.Keypad5))
            {
                anim.SetBool("pied", true);
            }
            if (Input.GetKeyUp(KeyCode.Keypad5))
            {
                anim.SetBool("pied", false);
            }
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                anim.SetBool("poing2", true);
            }
            if (Input.GetKeyUp(KeyCode.Keypad1))
            {
                anim.SetBool("poing2", false);
            }
        }
        fonction_saut();     
    }

    private void fonction_saut()
    {

        if (rb.position.y <= 2)
        {
            //cl.enabled = true;
            VerticalForce = 0;
            if (saut_joueur)
            {
                compteur = 80;
               // cl.enabled = false;
            }
        }
        if (compteur > 0)
        {
            VerticalForce = 80;
            compteur--;
        }
        if (rb.position.y > 2)
        {
            if (compteur == 0)
            { 
                saut_joueur = false;
                VerticalForce = -80;
            }
        }
    }
}
