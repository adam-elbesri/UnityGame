using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur_IA : MonoBehaviour
{
    public GameObject player2;
    private nbJoueur nbj;

    // Start is called before the first frame update
    void Start()
    {
        player2.GetComponent<testerb>().enabled = false;
        player2.GetComponent<IA>().enabled = false;
        choix_joueur_IA();
    }

    private void choix_joueur_IA()
    {
        if(nbJoueur._joueur) player2.GetComponent<testerb>().enabled = true;
        else if (nbJoueur._IA) player2.GetComponent<IA>().enabled = true;
    }
}
