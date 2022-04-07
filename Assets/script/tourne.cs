using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tourne : MonoBehaviour
{
    public GameObject joueur;
    public GameObject adversaire;

    // Update is called once per frame
    void Update()
    {
        direction_regard();
    }

    void direction_regard()
    {
        if(joueur.transform.position.x < adversaire.transform.position.x)
        {
            joueur.transform.localScale = new Vector3(-1,1,1);
            adversaire.transform.localScale = new Vector3(1,1,1);
        }
        else if (joueur.transform.position.x > adversaire.transform.position.x)
        {
            joueur.transform.localScale = new Vector3(1,1,1);
            adversaire.transform.localScale = new Vector3(-1,1,1);
        }
    }
}
