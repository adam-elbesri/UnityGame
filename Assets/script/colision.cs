using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
    public AudioSource audioPoing, audioPied;
    public AudioClip poing, pied;
    public Vitalite vital;
    public GameObject Joueur;
    public Animator anim;
    
    private void OnTriggerEnter(Collider other)
    { 
        if(anim.GetBool("pied") || anim.GetBool("pied2") || anim.GetBool("poing") || anim.GetBool("poing2")) {
            if ((this.name == "MainD" || this.name == "MainG" || this.name == "pied G" ||
                this.name == "pied D") && (other.name == "Coup" || other.name == "Bas"))
            {
                if (this.name == "MainD" || this.name == "MainG") audioPoing.PlayOneShot(poing, 0.2F);
                if (this.name == "pied G" || this.name == "pied D") audioPied.PlayOneShot(pied, 0.2F);
                if (Joueur.tag == "player1")
                {
                    if (other.name == "Coup") vital.currentHealthJ2 = vital.currentHealthJ2 - 5;
                    else if (other.name == "Bas") vital.currentHealthJ2 = vital.currentHealthJ2 - 2;
                }
                if (Joueur.tag == "player2")
                {
                    if (other.name == "Coup") vital.currentHealthJ1 = vital.currentHealthJ1 - 5;
                    else if (other.name == "Bas") vital.currentHealthJ1 = vital.currentHealthJ1 - 2;
                }
            }
        }



        
    }
}
