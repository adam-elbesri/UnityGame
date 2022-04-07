using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour


{
    
    //public BarreDeVie  barredevie;
    
    public Vita vie;
    private void OnTriggerEnter(Collider other)
    {
        
     

           
        if( (this.name== "MainD"|| this.name== "MainG" || this.name== "pied G" || this.name== "pied D") &&  (other.name == "Coup" || other.name == "Bas"  ))
        {
           // print("TOUCHE ENRFONCE");
         
           vie.currentHealth=vie.currentHealth-5;
           //barredevie.SetHealth(currentHealth);
           print(this.name + " hit " + other.name);
        }
        
 
        
       /* if (this.tag == other.tag || other.tag == "player2" || other.name == "Coup")
        {
            print(this.name + " hit " + other.name);
        }*/
    }
}
