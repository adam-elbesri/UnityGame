using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    public Transform position_adv;
    private Animator anim;
    private float HorizontalForce;
    private float VerticalForce;
    private Rigidbody rb;
    private Collider cl;
    private int coup = 0;
    private float sens = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cl = GetComponent<Collider>();
        anim = GetComponent<Animator>();
        HorizontalForce = 0;
        VerticalForce = 0;
    }

    // Update is called once per frame
    void Update()
    {
        deplacement();
        frappe();
        gravite();
    }
    
    private void deplacement()
    {
       /* if(Input.GetKey("k"))
        {
            anim.SetBool("bas",true);
        }
        if(Input.GetKey("l")) 
        {
            anim.SetBool("bas",false);
        }*/
        if  (Mathf.Abs(this.transform.position.x - position_adv.position.x) > 16)
        {
            sens = Mathf.Abs(this.transform.position.x - position_adv.position.x) / (this.transform.position.x - position_adv.position.x);
            if (sens == -1)
            {
                anim.SetBool("recule", true);
                HorizontalForce = 15;
                rb.velocity = new Vector3(HorizontalForce, VerticalForce, 0);
            }
            if (sens == 1)
            {
                anim.SetBool("avance", true);
                HorizontalForce = -	15	;
                rb.velocity = new Vector3(HorizontalForce, VerticalForce, 0);
            }
        }
        else
        {
            HorizontalForce = 0;
            rb.velocity = new Vector3(HorizontalForce, VerticalForce, 0);
            anim.SetBool("recule", false);
            anim.SetBool("avance", false);
            coup = 5;
        }
    }

    private void frappe()
    {
        anim.SetBool("poing", false);
        anim.SetBool("pied", false);
        anim.SetBool("poing2", false);
        anim.SetBool("pied2", false);
        if (coup == 5)
        {   
            coup = Random.Range(0, 100);          
            if (coup == 1)
            {
                anim.SetBool("poing", true);
            }
            if (coup == 2)
            {
                anim.SetBool("pied", true);
            }
            if (coup == 3)
            {
                anim.SetBool("poing2", true);
            }
            if (coup == 4)
            {
                anim.SetBool("pied2", true);
            }
        }
    }

    private void gravite()
    {
        if (rb.position.y <= 2)
        {
            VerticalForce = 0;
        }
        else if (rb.position.y > 2)
        {
            VerticalForce = -80;
        }
    }

}
