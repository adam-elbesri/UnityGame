using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class camera : MonoBehaviour
{
    public Transform position_joueur1;
    public Transform position_joueur2;
    public float distance;
    public Vector3 hauteur;
    private Vector3 decalage = new Vector3(0, 30, 40);
    private Vector3 rotation = new Vector3(15,180,0);
    // Start is called before the first frame update
    void Start()
    {
        Quaternion target = Quaternion.Euler(0, 0, 0);
        transform.rotation = target;
        transform.position = milieu(position_joueur1.position,position_joueur2.position) + decalage;
        transform.Rotate(rotation);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Mathf.Abs(position_joueur1.position.x - position_joueur2.position.x);
        transform.position =new Vector3((position_joueur1.position.x + position_joueur2.position.x)/2,0,0) + decalage + hauteur;
        if (distance > 40)
        {
            decalage =new Vector3(0, 30, 20 + distance/2); 
        }
        if (position_joueur1.position.y != 0 || position_joueur2.position.y != 0)
        {
            hauteur = new Vector3(0,position_joueur1.position.y/3 + position_joueur2.position.y/3,0);
        }
    }

    private Vector3 milieu(Vector3 a,Vector3 b)
    {
        Vector3 c = new Vector3((a.x + b.x) / 2, (a.y + b.y) / 2 , (a.z + b.z) / 2);
        return c;
    }
}

