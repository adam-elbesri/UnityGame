using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChoixJoueur : MonoBehaviour
{   
    private bool cJ, imJ1;
    public static int J, J1, J2;
    private Button b;
    private ColorBlock cb;
    private Sprite perso1, perso2, perso3, perso4, perso5, perso6, perso7, perso8, perso9, perso10, perso11, perso12;
    private GameObject imageJ1, imageJ2;
    private GameObject Bouton1, Bouton2, Bouton3, Bouton4, Bouton5, Bouton6, Bouton7, Bouton8, Bouton9, Bouton10, Bouton11, Bouton12;
    private GameObject T_Confirmer;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        J1 =J2 =0;
        imJ1 = false;
        imageJ1 = GameObject.Find("ImageJ1");
        imageJ2 = GameObject.Find("ImageJ2");
        T_Confirmer = GameObject.Find("Text_confirmer");
        anim = GetComponent<Animator>();
        initBoutonGO();
        initSpritePerso();
    }
    
    public void confirmer()
    {
        cJ = true;
        if(cJ == true && J1 == 0)
        {
            J1 = J;
            cJ = false;
            if(J1 != 0 )
            {
                imJ1 = true;
                T_Confirmer.gameObject.GetComponent<Text>().text = "CONFIRMER J2"; 
            }        
        }
        if (cJ == true && J1 != 0 && J2 == 0)
        {
            J2 = J;
            cJ = false;
            anim.SetBool("Menu", true);
            T_Confirmer.gameObject.GetComponent<Text>().text = "Suivant";
        }
        if(cJ == true && J1!=0 && J2!=0)
        {
            SceneManager.LoadScene(4);
        }
        boutonColors();
    }

    private void boutonColors()
     {
        if (J1==1 || J2==1) {cb = Bouton1.gameObject.GetComponent<Button>().colors; cb.normalColor = Color.white; Bouton1.gameObject.GetComponent<Button>().colors = cb;}
        if (J1==2 || J2==2) {cb = Bouton2.gameObject.GetComponent<Button>().colors; cb.normalColor = Color.white; Bouton2.gameObject.GetComponent<Button>().colors = cb;}
        if (J1==3 || J2==3) {cb = Bouton3.gameObject.GetComponent<Button>().colors; cb.normalColor = Color.white; Bouton3.gameObject.GetComponent<Button>().colors = cb;}
        if (J1==4 || J2==4) {cb = Bouton4.gameObject.GetComponent<Button>().colors; cb.normalColor = Color.white; Bouton4.gameObject.GetComponent<Button>().colors = cb;}
        if (J1==5 || J2==5) {cb = Bouton5.gameObject.GetComponent<Button>().colors; cb.normalColor = Color.white; Bouton5.gameObject.GetComponent<Button>().colors = cb;}
        if (J1==6 || J2==6) {cb = Bouton6.gameObject.GetComponent<Button>().colors; cb.normalColor = Color.white; Bouton6.gameObject.GetComponent<Button>().colors = cb;}
        if (J1==7 || J2==7) {cb = Bouton7.gameObject.GetComponent<Button>().colors; cb.normalColor = Color.white; Bouton7.gameObject.GetComponent<Button>().colors = cb;}
        if (J1==8 || J2==8) {cb = Bouton8.gameObject.GetComponent<Button>().colors; cb.normalColor = Color.white; Bouton8.gameObject.GetComponent<Button>().colors = cb;}
        if (J1==9 || J2==9) {cb = Bouton9.gameObject.GetComponent<Button>().colors; cb.normalColor = Color.white; Bouton9.gameObject.GetComponent<Button>().colors = cb;}
        if (J1==10 || J2==10) {cb = Bouton10.gameObject.GetComponent<Button>().colors; cb.normalColor = Color.white; Bouton10.gameObject.GetComponent<Button>().colors = cb;}
        if (J1==11 || J2==11) {cb = Bouton11.gameObject.GetComponent<Button>().colors; cb.normalColor = Color.white; Bouton11.gameObject.GetComponent<Button>().colors = cb;}
        if (J1==12 || J2==12) {cb = Bouton12.gameObject.GetComponent<Button>().colors; cb.normalColor = Color.white; Bouton12.gameObject.GetComponent<Button>().colors = cb;}
     }

    public void cj1(){J = 1;}
    public void cj2(){J = 2;}
    public void cj3(){J = 3;}
    public void cj4(){J = 4;}
    public void cj5(){J = 5;}
    public void cj6(){J = 6;}
    public void cj7(){J = 7;}
    public void cj8(){J = 8;}    
    public void cj9(){J = 9;}
    public void cj10(){J = 10;}
    public void cj11(){J = 11;}
    public void cj12(){J = 12;}    


    public void im1_J1(){if(!imJ1) imageJ1.gameObject.GetComponent<Image>().sprite = perso1;}
    public void im1_J2(){if(!imJ1) imageJ1.gameObject.GetComponent<Image>().sprite = perso2;}
    public void im1_J3(){if(!imJ1) imageJ1.gameObject.GetComponent<Image>().sprite = perso3;}
    public void im1_J4(){if(!imJ1) imageJ1.gameObject.GetComponent<Image>().sprite = perso4;}
    public void im1_J5(){if(!imJ1) imageJ1.gameObject.GetComponent<Image>().sprite = perso5;}
    public void im1_J6(){if(!imJ1) imageJ1.gameObject.GetComponent<Image>().sprite = perso6;}
    public void im1_J7(){if(!imJ1) imageJ1.gameObject.GetComponent<Image>().sprite = perso7;}
    public void im1_J8(){if(!imJ1) imageJ1.gameObject.GetComponent<Image>().sprite = perso8;}
    public void im1_J9(){if(!imJ1) imageJ1.gameObject.GetComponent<Image>().sprite = perso9;}
    public void im1_J10(){if(!imJ1) imageJ1.gameObject.GetComponent<Image>().sprite = perso10;}
    public void im1_J11(){if(!imJ1) imageJ1.gameObject.GetComponent<Image>().sprite = perso11;}
    public void im1_J12(){if(!imJ1) imageJ1.gameObject.GetComponent<Image>().sprite = perso12;}


    public void im2_J1(){if(imJ1 && J2 == 0) imageJ2.gameObject.GetComponent<Image>().sprite = perso1;}
    public void im2_J2(){if(imJ1 && J2 == 0) imageJ2.gameObject.GetComponent<Image>().sprite = perso2;}
    public void im2_J3(){if(imJ1 && J2 == 0) imageJ2.gameObject.GetComponent<Image>().sprite = perso3;}
    public void im2_J4(){if(imJ1 && J2 == 0) imageJ2.gameObject.GetComponent<Image>().sprite = perso4;}
    public void im2_J5(){if(imJ1 && J2 == 0) imageJ2.gameObject.GetComponent<Image>().sprite = perso5;}
    public void im2_J6(){if(imJ1 && J2 == 0) imageJ2.gameObject.GetComponent<Image>().sprite = perso6;}
    public void im2_J7(){if(imJ1 && J2 == 0) imageJ2.gameObject.GetComponent<Image>().sprite = perso7;}
    public void im2_J8(){if(imJ1 && J2 == 0) imageJ2.gameObject.GetComponent<Image>().sprite = perso8;}
    public void im2_J9(){if(imJ1 && J2 == 0) imageJ2.gameObject.GetComponent<Image>().sprite = perso9;}
    public void im2_J10(){if(imJ1 && J2 == 0) imageJ2.gameObject.GetComponent<Image>().sprite = perso10;}
    public void im2_J11(){if(imJ1 && J2 == 0) imageJ2.gameObject.GetComponent<Image>().sprite = perso11;}
    public void im2_J12(){if(imJ1 && J2 == 0) imageJ2.gameObject.GetComponent<Image>().sprite = perso12;}


    private void initBoutonGO()
    {
        Bouton1 = GameObject.Find("boutonJ1");
        Bouton2 = GameObject.Find("boutonJ2");
        Bouton3 = GameObject.Find("boutonJ3");
        Bouton4 = GameObject.Find("boutonJ4");
        Bouton5 = GameObject.Find("boutonJ5");
        Bouton6 = GameObject.Find("boutonJ6");
        Bouton7 = GameObject.Find("boutonJ7");
        Bouton8 = GameObject.Find("boutonJ8");
        Bouton9 = GameObject.Find("boutonJ9");
        Bouton10 = GameObject.Find("boutonJ10");
        Bouton11 = GameObject.Find("boutonJ11");
        Bouton12 = GameObject.Find("boutonJ12");
    }

    private void initSpritePerso()
    {
        perso1 = Bouton1.gameObject.GetComponent<Image>().sprite;
        perso2 = Bouton2.gameObject.GetComponent<Image>().sprite;
        perso3 = Bouton3.gameObject.GetComponent<Image>().sprite;
        perso4 = Bouton4.gameObject.GetComponent<Image>().sprite;
        perso5 = Bouton5.gameObject.GetComponent<Image>().sprite;
        perso6 = Bouton6.gameObject.GetComponent<Image>().sprite;
        perso7 = Bouton7.gameObject.GetComponent<Image>().sprite;
        perso8 = Bouton8.gameObject.GetComponent<Image>().sprite;
        perso9 = Bouton9.gameObject.GetComponent<Image>().sprite;
        perso10 = Bouton10.gameObject.GetComponent<Image>().sprite;
        perso11 = Bouton11.gameObject.GetComponent<Image>().sprite;
        perso12 = Bouton12.gameObject.GetComponent<Image>().sprite;
    }
}




