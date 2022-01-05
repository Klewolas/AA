using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCemberKod : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hiz;
    bool hareketKontrol = false;
    GameObject OyunYoneticisi;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        OyunYoneticisi = GameObject.FindGameObjectWithTag("OyunYoneticisiTag");
    }

    void FixedUpdate()
    {
        if (!hareketKontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }
      
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "DonenCemberTag")
        {
            transform.SetParent(col.transform);
            hareketKontrol = true;
        }
        if(col.tag == "KucukCemberTag")
        {
            OyunYoneticisi.GetComponent<OyunYoneticisi>().OyunBitti();
        }
    }
}
