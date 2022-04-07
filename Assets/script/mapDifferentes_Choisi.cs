using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapDifferentes_Choisi : MonoBehaviour
{
    private ChoixMap cm;

    public  GameObject MurD, MurG, Mur_Arriere, Sol;

    public GameObject d1_sol, d1_arriere, d1_G, d1_D, d2_sol, d2_arriere, d2_G, d2_D, d3_sol, d3_arriere, d3_G, d3_D, d4_sol, d4_arriere, d4_G, d4_D;

    // Start is called before the first frame update
    void Start()
    {
        d1_arriere.SetActive(false);
        d1_D.SetActive(false);
        d1_G.SetActive(false);
        d1_sol.SetActive(false);
        d2_arriere.SetActive(false);
        d2_D.SetActive(false);
        d2_G.SetActive(false);
        d2_sol.SetActive(false);
        d3_arriere.SetActive(false);
        d3_D.SetActive(false);
        d3_G.SetActive(false);
        d3_sol.SetActive(false);
        d4_arriere.SetActive(false);
        d4_D.SetActive(false);
        d4_G.SetActive(false);
        d4_sol.SetActive(false);
        decorChoisi();
    }


    public void decor1()
    {
        d1_arriere.SetActive(true);
        d1_D.SetActive(true);
        d1_G.SetActive(true);
        d1_sol.SetActive(true);
    }

    public void decor2()
    {
        d2_arriere.SetActive(true);
        d2_D.SetActive(true);
        d2_G.SetActive(true);
        d2_sol.SetActive(true);
    }

    public void decor3()
    {
        d3_arriere.SetActive(true);
        d3_D.SetActive(true);
        d3_G.SetActive(true);
        d3_sol.SetActive(true);
    }

    public void decor4()
    {
        d4_arriere.SetActive(true);
        d4_D.SetActive(true);
        d4_G.SetActive(true);
        d4_sol.SetActive(true);
    }

    public void decorChoisi()
    {
        if(ChoixMap.M == 1) decor1();

        if(ChoixMap.M == 2) decor2();

        if(ChoixMap.M == 3) decor3();

        if(ChoixMap.M == 4) decor4();
    }
}
