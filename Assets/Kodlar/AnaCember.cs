using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaCember : MonoBehaviour
{
    public GameObject KucukCember;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            KucukCemberOlustur();
        }
    }
    void KucukCemberOlustur()
    {
        Instantiate(KucukCember, transform.position, transform.rotation);
    }
}
