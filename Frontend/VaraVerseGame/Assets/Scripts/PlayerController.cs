using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Direction",Input.GetAxis("Horizontal"));
        animator.SetFloat("Speed", Input.GetAxis("Vertical"));
    }
}
