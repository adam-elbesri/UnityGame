using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vitalite : MonoBehaviour
{
    public GameObject Joueur1, Joueur2;
    public BarreDeVie  barredevieJ1, barredevieJ2;

    public AudioSource AudioKO, audioTimeOver, audioYouWin, audioYouLose;
    public AudioClip KO, timeOver, youWin, youLose;

    private Timer t;

    private int maxHealth;
    public int currentHealthJ1, currentHealthJ2;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 50;
        currentHealthJ1=maxHealth;
        currentHealthJ2=maxHealth;

        barredevieJ1.SetMaxHealth(maxHealth);
        barredevieJ2.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        barredevieJ1.SetHealth(currentHealthJ1);
        barredevieJ2.SetHealth(currentHealthJ2);


        fin_de_jeu();
    }

    private void fin_de_jeu()
    {
        if(currentHealthJ1 < 0)
        {   
            if(Joueur2.GetComponent<IA>().enabled == true) audioYouLose.PlayOneShot(youLose,0.1F);
            else AudioKO.PlayOneShot(KO,0.1F);
            
            desactivation();
            Joueur1.GetComponent<Animator>().SetBool("mort", true);
            Joueur2.GetComponent<Animator>().SetBool("win",true);
        }

        if(currentHealthJ2 < 0)
        {
            if(Joueur2.GetComponent<IA>().enabled == true) audioYouWin.PlayOneShot(youWin,0.1F);
            else AudioKO.PlayOneShot(KO,0.1F);

            desactivation();
            Joueur1.GetComponent<Animator>().SetBool("win",true);
            Joueur2.GetComponent<Animator>().SetBool("mort", true);  
        }

        if(Timer.time > Timer.horloge)
        {
            audioTimeOver.PlayOneShot(timeOver,0.1F);

            desactivation();
            
            if(currentHealthJ2 < currentHealthJ1)
            {   
                Joueur1.GetComponent<Animator>().SetBool("win",true);
                Joueur2.GetComponent<Animator>().SetBool("mort", true);  
            }
            else if(currentHealthJ1 < currentHealthJ2)
            {   
                Joueur1.GetComponent<Animator>().SetBool("mort", true);
                Joueur2.GetComponent<Animator>().SetBool("win",true);
            }
            else
            {
                Joueur1.GetComponent<Animator>().SetBool("mort", true);
                Joueur2.GetComponent<Animator>().SetBool("mort", true);
            }
        }
    }

    private void desactivation()
    {   
        Joueur1.GetComponent<testerb>().enabled = false;
        Joueur2.GetComponent<testerb>().enabled = false;
        Joueur2.GetComponent<IA>().enabled = false;
        
        Joueur1.GetComponent<Animator>().SetBool("pied", false);
        Joueur1.GetComponent<Animator>().SetBool("pied2", false);
        Joueur1.GetComponent<Animator>().SetBool("poing", false);
        Joueur1.GetComponent<Animator>().SetBool("poing2", false);
        Joueur1.GetComponent<Animator>().SetBool("avance", false);
        Joueur1.GetComponent<Animator>().SetBool("recule", false);
        Joueur1.GetComponent<Animator>().SetBool("bas", false);
        Joueur1.GetComponent<Animator>().SetBool("saut", false);


        Joueur2.GetComponent<Animator>().SetBool("pied", false);
        Joueur2.GetComponent<Animator>().SetBool("pied2", false);
        Joueur2.GetComponent<Animator>().SetBool("poing", false);
        Joueur2.GetComponent<Animator>().SetBool("poing2", false);
        Joueur2.GetComponent<Animator>().SetBool("avance", false);
        Joueur2.GetComponent<Animator>().SetBool("recule", false);
        Joueur2.GetComponent<Animator>().SetBool("bas", false);
        Joueur2.GetComponent<Animator>().SetBool("saut", false);

        Joueur1.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
        Joueur2.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
    }
}
