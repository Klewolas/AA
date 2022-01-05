using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunYoneticisi : MonoBehaviour
{
    GameObject donenCember;
    GameObject anaCember;
    public Animator animator;
    void Start()
    {
        donenCember = GameObject.FindGameObjectWithTag("DonenCemberTag");
        anaCember = GameObject.FindGameObjectWithTag("AnaCemberTag");
    }

    public void OyunBitti()
    {
        donenCember.GetComponent<Dondurme>().enabled = false;
        anaCember.GetComponent<AnaCember>().enabled = false;
        animator.SetTrigger("OyunBitti");

    }
}
