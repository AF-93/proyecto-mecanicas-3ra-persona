using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{   
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Chocolate"))
        {
            animator.SetTrigger("dead");
        }
    }
}
