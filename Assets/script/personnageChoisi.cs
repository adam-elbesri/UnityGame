using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personnageChoisi : MonoBehaviour
{
    private ChoixJoueur cj;
    public GameObject j1, j2;


    // Start is called before the first frame update
    void Start()
    {
        personnagesChoisis();
    }

    void personnagesChoisis()
    {
        if(ChoixJoueur.J1 == 1) j1.GetComponent<personnageDifferent>().caractere1();
        if(ChoixJoueur.J2 == 1) j2.GetComponent<personnageDifferent>().caractere1();
        if(ChoixJoueur.J1 == 2) j1.GetComponent<personnageDifferent>().caractere2();
        if(ChoixJoueur.J2 == 2) j2.GetComponent<personnageDifferent>().caractere2();
        if(ChoixJoueur.J1 == 3) j1.GetComponent<personnageDifferent>().caractere3();
        if(ChoixJoueur.J2 == 3) j2.GetComponent<personnageDifferent>().caractere3();
        if(ChoixJoueur.J1 == 4) j1.GetComponent<personnageDifferent>().caractere4();
        if(ChoixJoueur.J2 == 4) j2.GetComponent<personnageDifferent>().caractere4();
        if(ChoixJoueur.J1 == 5) j1.GetComponent<personnageDifferent>().caractere5();
        if(ChoixJoueur.J2 == 5) j2.GetComponent<personnageDifferent>().caractere5();
        if(ChoixJoueur.J1 == 6) j1.GetComponent<personnageDifferent>().caractere6();
        if(ChoixJoueur.J2 == 6) j2.GetComponent<personnageDifferent>().caractere6();
        if(ChoixJoueur.J1 == 7) j1.GetComponent<personnageDifferent>().caractere7();
        if(ChoixJoueur.J2 == 7) j2.GetComponent<personnageDifferent>().caractere7();
        if(ChoixJoueur.J1 == 8) j1.GetComponent<personnageDifferent>().caractere8();
        if(ChoixJoueur.J2 == 8) j2.GetComponent<personnageDifferent>().caractere8();
        if(ChoixJoueur.J1 == 9) j1.GetComponent<personnageDifferent>().caractere9();
        if(ChoixJoueur.J2 == 9) j2.GetComponent<personnageDifferent>().caractere9();
        if(ChoixJoueur.J1 == 10) j1.GetComponent<personnageDifferent>().caractere10();
        if(ChoixJoueur.J2 == 10) j2.GetComponent<personnageDifferent>().caractere10();
        if(ChoixJoueur.J1 == 11) j1.GetComponent<personnageDifferent>().caractere11();
        if(ChoixJoueur.J2 == 11) j2.GetComponent<personnageDifferent>().caractere11();
        if(ChoixJoueur.J1 == 12) j1.GetComponent<personnageDifferent>().caractere12();
        if(ChoixJoueur.J2 == 12) j2.GetComponent<personnageDifferent>().caractere12();
    }
}
