using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XY_Animation : MonoBehaviour
{
    protected Animator animator;
    protected XY_CharacterController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<XY_CharacterController>();
    }
}
