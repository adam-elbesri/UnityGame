using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nbJoueur : MonoBehaviour
{
    public static bool _joueur, _IA; 

    // Start is called before the first frame update
    void Start()
    {
        _joueur = _IA = false;
    }

    public void joueurvsjoueur()
    {
        _joueur = true;
    }

    public void joueurvsIA()
    {   
        _IA = true;
    }
}
