using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personnageDifferent : MonoBehaviour
{
    public  GameObject Bas, Corps_bas, Milieu_corps, Corps_Haut, Coup, Tete, Oeil_G, Oeil_D, Epaules, Epaule_G, Bras_G, Coude_G, Avant_Bras_G, Main_G, Epaule_D, Bras_D, Coude_D, Avant_Bras_D, Main_D;
    public  GameObject pied_D, tibia_D, genoux_D, jambe_D, pied_G, tibia_G, genoux_G, jambe_G;

    public GameObject c2_pomme, c3_bandana1, c3_bandana2, c3_bandana3, c5_antenne1, c5_antenne2, c7_oeil, c9_chapeau, c12_lunette;

    public  Material vert, bordeaux, marron, noir, rouge, blanc, bleu_modif, rose, noir_flamme, orange, or, gris;

    void Start()
    {
        c2_pomme.SetActive(false);
        c3_bandana1.SetActive(false);
        c3_bandana2.SetActive(false);
        c3_bandana3.SetActive(false);
        c5_antenne1.SetActive(false);
        c5_antenne2.SetActive(false);
        c7_oeil.SetActive(false);
        c9_chapeau.SetActive(false);  
        c12_lunette.SetActive(false);
    }

    public void caractere1()
    {
        Bas.GetComponent<Renderer>().material = bordeaux;
        Corps_bas.GetComponent<Renderer>().material = bordeaux;
        Milieu_corps.GetComponent<Renderer>().material = bordeaux;
        Corps_Haut.GetComponent<Renderer>().material = bordeaux;
        Coup.GetComponent<Renderer>().material = bordeaux;
        Tete.GetComponent<Renderer>().material = bordeaux;
        Oeil_D.GetComponent<Renderer>().material = noir;
        Oeil_G.GetComponent<Renderer>().material = noir;
        Epaules.GetComponent<Renderer>().material = bordeaux;
        Epaule_G.GetComponent<Renderer>().material = bordeaux;
        Bras_G.GetComponent<Renderer>().material = bordeaux;
        Coude_G.GetComponent<Renderer>().material = bordeaux;
        Avant_Bras_G.GetComponent<Renderer>().material = bordeaux;
        Main_G.GetComponent<Renderer>().material = noir;
        Epaule_D.GetComponent<Renderer>().material = bordeaux;
        Bras_D.GetComponent<Renderer>().material = bordeaux;
        Coude_D.GetComponent<Renderer>().material = bordeaux;
        Avant_Bras_D.GetComponent<Renderer>().material = bordeaux;
        Main_D.GetComponent<Renderer>().material = noir;
        pied_D.GetComponent<Renderer>().material = noir;
        tibia_D.GetComponent<Renderer>().material = bordeaux;
        genoux_D.GetComponent<Renderer>().material = bordeaux;
        jambe_D.GetComponent<Renderer>().material = bordeaux;
        pied_G.GetComponent<Renderer>().material = noir;
        tibia_G.GetComponent<Renderer>().material = bordeaux;
        genoux_G.GetComponent<Renderer>().material = bordeaux;
        jambe_G.GetComponent<Renderer>().material = bordeaux;

    }

    public void caractere2()
    {
        Bas.GetComponent<Renderer>().material = vert;
        Corps_bas.GetComponent<Renderer>().material = vert;
        Milieu_corps.GetComponent<Renderer>().material = vert;
        Corps_Haut.GetComponent<Renderer>().material = vert;
        Coup.GetComponent<Renderer>().material = vert;
        Tete.GetComponent<Renderer>().material = vert;
        Oeil_D.GetComponent<Renderer>().material = noir;
        Oeil_G.GetComponent<Renderer>().material = noir;
        Epaules.GetComponent<Renderer>().material = vert;
        Epaule_G.GetComponent<Renderer>().material = vert;
        Bras_G.GetComponent<Renderer>().material = vert;
        Coude_G.GetComponent<Renderer>().material = vert;
        Avant_Bras_G.GetComponent<Renderer>().material = vert;
        Main_G.GetComponent<Renderer>().material = noir;
        Epaule_D.GetComponent<Renderer>().material = vert;
        Bras_D.GetComponent<Renderer>().material = vert;
        Coude_D.GetComponent<Renderer>().material = vert;
        Avant_Bras_D.GetComponent<Renderer>().material = vert;
        Main_D.GetComponent<Renderer>().material = noir;
        pied_D.GetComponent<Renderer>().material = noir;
        tibia_D.GetComponent<Renderer>().material = vert;
        genoux_D.GetComponent<Renderer>().material = vert;
        jambe_D.GetComponent<Renderer>().material = vert;
        pied_G.GetComponent<Renderer>().material = noir;
        tibia_G.GetComponent<Renderer>().material = vert;
        genoux_G.GetComponent<Renderer>().material = vert;
        jambe_G.GetComponent<Renderer>().material = vert;
        c2_pomme.SetActive(true);
    }

    public void caractere3()
    {
        Bas.GetComponent<Renderer>().material = noir;
        Corps_bas.GetComponent<Renderer>().material = noir;
        Milieu_corps.GetComponent<Renderer>().material = noir;
        Corps_Haut.GetComponent<Renderer>().material = noir;
        Coup.GetComponent<Renderer>().material = noir;
        Tete.GetComponent<Renderer>().material = noir;
        Oeil_D.GetComponent<Renderer>().material = blanc;
        Oeil_G.GetComponent<Renderer>().material = blanc;
        Epaules.GetComponent<Renderer>().material = noir;
        Epaule_G.GetComponent<Renderer>().material = noir;
        Bras_G.GetComponent<Renderer>().material = noir;
        Coude_G.GetComponent<Renderer>().material = noir;
        Avant_Bras_G.GetComponent<Renderer>().material = noir;
        Main_G.GetComponent<Renderer>().material = rouge;
        Epaule_D.GetComponent<Renderer>().material = noir;
        Bras_D.GetComponent<Renderer>().material = noir;
        Coude_D.GetComponent<Renderer>().material = noir;
        Avant_Bras_D.GetComponent<Renderer>().material = noir;
        Main_D.GetComponent<Renderer>().material = rouge;
        pied_D.GetComponent<Renderer>().material = rouge;
        tibia_D.GetComponent<Renderer>().material = noir;
        genoux_D.GetComponent<Renderer>().material = noir;
        jambe_D.GetComponent<Renderer>().material = noir;
        pied_G.GetComponent<Renderer>().material = rouge;
        tibia_G.GetComponent<Renderer>().material = noir;
        genoux_G.GetComponent<Renderer>().material = noir;
        jambe_G.GetComponent<Renderer>().material = noir;
        c3_bandana1.SetActive(true);
        c3_bandana2.SetActive(true);
        c3_bandana3.SetActive(true);
    }

    public void caractere4()
    {
        Bas.GetComponent<Renderer>().material = bleu_modif;
        Corps_bas.GetComponent<Renderer>().material = bleu_modif;
        Milieu_corps.GetComponent<Renderer>().material = bleu_modif;
        Corps_Haut.GetComponent<Renderer>().material = bleu_modif;
        Coup.GetComponent<Renderer>().material = bleu_modif;
        Tete.GetComponent<Renderer>().material = bleu_modif;
        Oeil_D.GetComponent<Renderer>().material = rouge;
        Oeil_G.GetComponent<Renderer>().material = rouge;
        Epaules.GetComponent<Renderer>().material = bleu_modif;
        Epaule_G.GetComponent<Renderer>().material = bleu_modif;
        Bras_G.GetComponent<Renderer>().material = bleu_modif;
        Coude_G.GetComponent<Renderer>().material = bleu_modif;
        Avant_Bras_G.GetComponent<Renderer>().material = bleu_modif;
        Main_G.GetComponent<Renderer>().material = bleu_modif;
        Epaule_D.GetComponent<Renderer>().material = bleu_modif;
        Bras_D.GetComponent<Renderer>().material = bleu_modif;
        Coude_D.GetComponent<Renderer>().material = bleu_modif;
        Avant_Bras_D.GetComponent<Renderer>().material = bleu_modif;
        Main_D.GetComponent<Renderer>().material = bleu_modif;
        pied_D.GetComponent<Renderer>().material = bleu_modif;
        tibia_D.GetComponent<Renderer>().material = bleu_modif;
        genoux_D.GetComponent<Renderer>().material = bleu_modif;
        jambe_D.GetComponent<Renderer>().material = bleu_modif;
        pied_G.GetComponent<Renderer>().material = bleu_modif;
        tibia_G.GetComponent<Renderer>().material = bleu_modif;
        genoux_G.GetComponent<Renderer>().material = bleu_modif;
        jambe_G.GetComponent<Renderer>().material = bleu_modif;
    }

    public void caractere5()
    {
        Bas.GetComponent<Renderer>().material = rose;
        Corps_bas.GetComponent<Renderer>().material = rose;
        Milieu_corps.GetComponent<Renderer>().material = rose;
        Corps_Haut.GetComponent<Renderer>().material = rose;
        Coup.GetComponent<Renderer>().material = rose;
        Tete.GetComponent<Renderer>().material = rose;
        Oeil_D.GetComponent<Renderer>().material = vert;
        Oeil_G.GetComponent<Renderer>().material = vert;
        Epaules.GetComponent<Renderer>().material = rose;
        Epaule_G.GetComponent<Renderer>().material = rose;
        Bras_G.GetComponent<Renderer>().material = rose;
        Coude_G.GetComponent<Renderer>().material = rose;
        Avant_Bras_G.GetComponent<Renderer>().material = rose;
        Main_G.GetComponent<Renderer>().material = rose;
        Epaule_D.GetComponent<Renderer>().material = rose;
        Bras_D.GetComponent<Renderer>().material = rose;
        Coude_D.GetComponent<Renderer>().material = rose;
        Avant_Bras_D.GetComponent<Renderer>().material = rose;
        Main_D.GetComponent<Renderer>().material = rose;
        pied_D.GetComponent<Renderer>().material = rose;
        tibia_D.GetComponent<Renderer>().material = rose;
        genoux_D.GetComponent<Renderer>().material = rose;
        jambe_D.GetComponent<Renderer>().material = rose;
        pied_G.GetComponent<Renderer>().material = rose;
        tibia_G.GetComponent<Renderer>().material = rose;
        genoux_G.GetComponent<Renderer>().material = rose;
        jambe_G.GetComponent<Renderer>().material = rose;
        c5_antenne1.SetActive(true);
        c5_antenne2.SetActive(true);
    }

    public void caractere6()
    {
        Bas.GetComponent<Renderer>().material = noir_flamme;
        Corps_bas.GetComponent<Renderer>().material = noir_flamme;
        Milieu_corps.GetComponent<Renderer>().material = noir_flamme;
        Corps_Haut.GetComponent<Renderer>().material = noir_flamme;
        Coup.GetComponent<Renderer>().material = noir_flamme;
        Tete.GetComponent<Renderer>().material = noir_flamme;
        Oeil_D.GetComponent<Renderer>().material = noir;
        Oeil_G.GetComponent<Renderer>().material = noir;
        Epaules.GetComponent<Renderer>().material = noir_flamme;
        Epaule_G.GetComponent<Renderer>().material = noir_flamme;
        Bras_G.GetComponent<Renderer>().material = noir_flamme;
        Coude_G.GetComponent<Renderer>().material = noir_flamme;
        Avant_Bras_G.GetComponent<Renderer>().material = noir_flamme;
        Main_G.GetComponent<Renderer>().material = noir_flamme;
        Epaule_D.GetComponent<Renderer>().material = noir_flamme;
        Bras_D.GetComponent<Renderer>().material = noir_flamme;
        Coude_D.GetComponent<Renderer>().material = noir_flamme;
        Avant_Bras_D.GetComponent<Renderer>().material = noir_flamme;
        Main_D.GetComponent<Renderer>().material = noir_flamme;
        pied_D.GetComponent<Renderer>().material = noir_flamme;
        tibia_D.GetComponent<Renderer>().material = noir_flamme;
        genoux_D.GetComponent<Renderer>().material = noir_flamme;
        jambe_D.GetComponent<Renderer>().material = noir_flamme;
        pied_G.GetComponent<Renderer>().material = noir_flamme;
        tibia_G.GetComponent<Renderer>().material = noir_flamme;
        genoux_G.GetComponent<Renderer>().material = noir_flamme;
        jambe_G.GetComponent<Renderer>().material = noir_flamme;
    }

    public void caractere7()
    {
        Bas.GetComponent<Renderer>().material = noir;
        Corps_bas.GetComponent<Renderer>().material = noir;
        Milieu_corps.GetComponent<Renderer>().material = noir;
        Corps_Haut.GetComponent<Renderer>().material = noir;
        Coup.GetComponent<Renderer>().material = noir;
        Tete.GetComponent<Renderer>().material = noir;
        Oeil_D.GetComponent<Renderer>().material = rouge;
        Oeil_G.GetComponent<Renderer>().material = rouge;
        Epaules.GetComponent<Renderer>().material = noir;
        Epaule_G.GetComponent<Renderer>().material = noir;
        Bras_G.GetComponent<Renderer>().material = noir;
        Coude_G.GetComponent<Renderer>().material = noir;
        Avant_Bras_G.GetComponent<Renderer>().material = noir;
        Main_G.GetComponent<Renderer>().material = noir;
        Epaule_D.GetComponent<Renderer>().material = noir;
        Bras_D.GetComponent<Renderer>().material = noir;
        Coude_D.GetComponent<Renderer>().material = noir;
        Avant_Bras_D.GetComponent<Renderer>().material = noir;
        Main_D.GetComponent<Renderer>().material = noir;
        pied_D.GetComponent<Renderer>().material = noir;
        tibia_D.GetComponent<Renderer>().material = noir;
        genoux_D.GetComponent<Renderer>().material = noir;
        jambe_D.GetComponent<Renderer>().material = noir;
        pied_G.GetComponent<Renderer>().material = noir;
        tibia_G.GetComponent<Renderer>().material = noir;
        genoux_G.GetComponent<Renderer>().material = noir;
        jambe_G.GetComponent<Renderer>().material = noir;
        c7_oeil.SetActive(true);
    }

    public void caractere8()
    {
        Bas.GetComponent<Renderer>().material = orange;
        Corps_bas.GetComponent<Renderer>().material = orange;
        Milieu_corps.GetComponent<Renderer>().material = orange;
        Corps_Haut.GetComponent<Renderer>().material = orange;
        Coup.GetComponent<Renderer>().material = orange;
        Tete.GetComponent<Renderer>().material = noir;
        Oeil_D.GetComponent<Renderer>().material = orange;
        Oeil_G.GetComponent<Renderer>().material = orange;
        Epaules.GetComponent<Renderer>().material = orange;
        Epaule_G.GetComponent<Renderer>().material = orange;
        Bras_G.GetComponent<Renderer>().material = orange;
        Coude_G.GetComponent<Renderer>().material = orange;
        Avant_Bras_G.GetComponent<Renderer>().material = noir;
        Main_G.GetComponent<Renderer>().material = noir;
        Epaule_D.GetComponent<Renderer>().material = orange;
        Bras_D.GetComponent<Renderer>().material = orange;
        Coude_D.GetComponent<Renderer>().material = orange;
        Avant_Bras_D.GetComponent<Renderer>().material = noir;
        Main_D.GetComponent<Renderer>().material = noir;
        pied_D.GetComponent<Renderer>().material = noir;
        tibia_D.GetComponent<Renderer>().material = orange;
        genoux_D.GetComponent<Renderer>().material = orange;
        jambe_D.GetComponent<Renderer>().material = orange;
        pied_G.GetComponent<Renderer>().material = noir;
        tibia_G.GetComponent<Renderer>().material = orange;
        genoux_G.GetComponent<Renderer>().material = orange;
        jambe_G.GetComponent<Renderer>().material = orange;
    }

    public void caractere9()
    {
        Bas.GetComponent<Renderer>().material = noir;
        Corps_bas.GetComponent<Renderer>().material = noir;
        Milieu_corps.GetComponent<Renderer>().material = noir;
        Corps_Haut.GetComponent<Renderer>().material = noir;
        Coup.GetComponent<Renderer>().material = noir;
        Tete.GetComponent<Renderer>().material = blanc;
        Oeil_D.GetComponent<Renderer>().material = noir;
        Oeil_G.GetComponent<Renderer>().material = noir;
        Epaules.GetComponent<Renderer>().material = noir;
        Epaule_G.GetComponent<Renderer>().material = noir;
        Bras_G.GetComponent<Renderer>().material = noir;
        Coude_G.GetComponent<Renderer>().material = noir;
        Avant_Bras_G.GetComponent<Renderer>().material = noir;
        Main_G.GetComponent<Renderer>().material = blanc;
        Epaule_D.GetComponent<Renderer>().material = noir;
        Bras_D.GetComponent<Renderer>().material = noir;
        Coude_D.GetComponent<Renderer>().material = noir;
        Avant_Bras_D.GetComponent<Renderer>().material = noir;
        Main_D.GetComponent<Renderer>().material = blanc;
        pied_D.GetComponent<Renderer>().material = blanc;
        tibia_D.GetComponent<Renderer>().material = noir;
        genoux_D.GetComponent<Renderer>().material = noir;
        jambe_D.GetComponent<Renderer>().material = noir;
        pied_G.GetComponent<Renderer>().material = blanc;
        tibia_G.GetComponent<Renderer>().material = noir;
        genoux_G.GetComponent<Renderer>().material = noir;
        jambe_G.GetComponent<Renderer>().material = noir;
        c9_chapeau.SetActive(true);
    }

    public void caractere10()
    {
        Bas.GetComponent<Renderer>().material = blanc;
        Corps_bas.GetComponent<Renderer>().material = blanc;
        Milieu_corps.GetComponent<Renderer>().material = blanc;
        Corps_Haut.GetComponent<Renderer>().material = blanc;
        Coup.GetComponent<Renderer>().material = blanc;
        Tete.GetComponent<Renderer>().material = blanc;
        Oeil_D.GetComponent<Renderer>().material = blanc;
        Oeil_G.GetComponent<Renderer>().material = blanc;
        Epaules.GetComponent<Renderer>().material = blanc;
        Epaule_G.GetComponent<Renderer>().material = blanc;
        Bras_G.GetComponent<Renderer>().material = blanc;
        Coude_G.GetComponent<Renderer>().material = blanc;
        Avant_Bras_G.GetComponent<Renderer>().material = blanc;
        Main_G.GetComponent<Renderer>().material = blanc;
        Epaule_D.GetComponent<Renderer>().material = blanc;
        Bras_D.GetComponent<Renderer>().material = blanc;
        Coude_D.GetComponent<Renderer>().material = blanc;
        Avant_Bras_D.GetComponent<Renderer>().material = blanc;
        Main_D.GetComponent<Renderer>().material = blanc;
        pied_D.GetComponent<Renderer>().material = blanc;
        tibia_D.GetComponent<Renderer>().material = blanc;
        genoux_D.GetComponent<Renderer>().material = blanc;
        jambe_D.GetComponent<Renderer>().material = blanc;
        pied_G.GetComponent<Renderer>().material = blanc;
        tibia_G.GetComponent<Renderer>().material = blanc;
        genoux_G.GetComponent<Renderer>().material = blanc;
        jambe_G.GetComponent<Renderer>().material = blanc;
    }

    public void caractere11()
    {
        Bas.GetComponent<Renderer>().material = or;
        Corps_bas.GetComponent<Renderer>().material = or;
        Milieu_corps.GetComponent<Renderer>().material = or;
        Corps_Haut.GetComponent<Renderer>().material = or;
        Coup.GetComponent<Renderer>().material = or;
        Tete.GetComponent<Renderer>().material = or;
        Oeil_D.GetComponent<Renderer>().material = or;
        Oeil_G.GetComponent<Renderer>().material = or;
        Epaules.GetComponent<Renderer>().material = or;
        Epaule_G.GetComponent<Renderer>().material = or;
        Bras_G.GetComponent<Renderer>().material = or;
        Coude_G.GetComponent<Renderer>().material = or;
        Avant_Bras_G.GetComponent<Renderer>().material = or;
        Main_G.GetComponent<Renderer>().material = or;
        Epaule_D.GetComponent<Renderer>().material = or;
        Bras_D.GetComponent<Renderer>().material = or;
        Coude_D.GetComponent<Renderer>().material = or;
        Avant_Bras_D.GetComponent<Renderer>().material = or;
        Main_D.GetComponent<Renderer>().material = or;
        pied_D.GetComponent<Renderer>().material = or;
        tibia_D.GetComponent<Renderer>().material = or;
        genoux_D.GetComponent<Renderer>().material = or;
        jambe_D.GetComponent<Renderer>().material = or;
        pied_G.GetComponent<Renderer>().material = or;
        tibia_G.GetComponent<Renderer>().material = or;
        genoux_G.GetComponent<Renderer>().material = or;
        jambe_G.GetComponent<Renderer>().material = or;
    }

    public void caractere12()
    {
        Bas.GetComponent<Renderer>().material = gris;
        Corps_bas.GetComponent<Renderer>().material = gris;
        Milieu_corps.GetComponent<Renderer>().material = gris;
        Corps_Haut.GetComponent<Renderer>().material = gris;
        Coup.GetComponent<Renderer>().material = gris;
        Tete.GetComponent<Renderer>().material = gris;
        Oeil_D.GetComponent<Renderer>().material = gris;
        Oeil_G.GetComponent<Renderer>().material = gris;
        Epaules.GetComponent<Renderer>().material = gris;
        Epaule_G.GetComponent<Renderer>().material = gris;
        Bras_G.GetComponent<Renderer>().material = gris;
        Coude_G.GetComponent<Renderer>().material = noir;
        Avant_Bras_G.GetComponent<Renderer>().material = noir;
        Main_G.GetComponent<Renderer>().material = noir;
        Epaule_D.GetComponent<Renderer>().material = gris;
        Bras_D.GetComponent<Renderer>().material = gris;
        Coude_D.GetComponent<Renderer>().material = noir;
        Avant_Bras_D.GetComponent<Renderer>().material = noir;
        Main_D.GetComponent<Renderer>().material = noir;
        pied_D.GetComponent<Renderer>().material = noir;
        tibia_D.GetComponent<Renderer>().material = noir;
        genoux_D.GetComponent<Renderer>().material = noir;
        jambe_D.GetComponent<Renderer>().material = gris;
        pied_G.GetComponent<Renderer>().material = noir;
        tibia_G.GetComponent<Renderer>().material = noir;
        genoux_G.GetComponent<Renderer>().material = noir;
        jambe_G.GetComponent<Renderer>().material = gris;
        c12_lunette.SetActive(true);
    }
}
