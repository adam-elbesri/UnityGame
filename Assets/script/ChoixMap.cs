using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChoixMap : MonoBehaviour
{
    public static int M;
    public Sprite map1, map2, map3, map4;
    private GameObject map;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        M=1;
        map = GameObject.Find("Map");
    }

    // Update is called once per frame
    void Update()
    {
        MapEnVue();
    }


    public void mapBas()
    {
        if(M>1) {M--;}
    }

    public void mapHaut()
    {
        if(M<4) {M++;}
    }

    private void MapEnVue()
    {
        if(M==1) map.gameObject.GetComponent<Image>().sprite = map1;
        if(M==2) map.gameObject.GetComponent<Image>().sprite = map2;
        if(M==3) map.gameObject.GetComponent<Image>().sprite = map3;
        if(M==4) map.gameObject.GetComponent<Image>().sprite = map4;
    }

    public void Map_choisi()
    {
        anim.SetBool("Map", true);       
        Invoke("lancer_Jeu", 0.5f);
    }

    private void lancer_Jeu()
    {
        SceneManager.LoadScene(5);
    }
    
    public void ChoixJoueur()
    {
        SceneManager.LoadScene(3);
    }
}
