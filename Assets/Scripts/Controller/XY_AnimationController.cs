using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class XY_AnimationController : XY_Animation
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");
    private static readonly int Attack = Animator.StringToHash("Attack");
    private static readonly int IsHit = Animator.StringToHash("IsHit");



    protected override void Awake()
    {
        
        base.Awake();
    }
    // Start is called before the first frame update
    void Start()
    {
        controller.MoveEvent += Move;
    }

    private void Move(Vector2 obj)
    {
        animator.SetBool(IsWalking, obj.magnitude > .5f);
    }

    private void Hit()
    {
        animator.SetBool(IsHit, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
