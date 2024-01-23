using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.SceneManagement;
using static UnityEditor.Experimental.GraphView.GraphView;

public enum CharacterType
{
    hero,
    monster
}
public class XY_CharacterController : MonoBehaviour
{
    public event Action<Vector2> MoveEvent;
    public event Action<Vector2> LookEvent;
    public event Action AttackEvent;

    public Enum CharacterSelect;
    private float _timeSinceLastAttack = float.MaxValue;
    protected bool IsAttacking {  get; set; }

    

    protected virtual void Update()
    {
        HandleAttackDelay();
    }

    private void HandleAttackDelay()
    {
        if(_timeSinceLastAttack <= 0.2f)
        {
            _timeSinceLastAttack += Time.deltaTime;
        }

        if(IsAttacking && _timeSinceLastAttack >0.2f)
        {
            _timeSinceLastAttack = 0;
            CallAttackEvent();
        }
    }
    public void CallMoveEvent(Vector2 direction)
    {
        MoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        LookEvent?.Invoke(direction);
    }

    public void CallAttackEvent()
    {
        AttackEvent?.Invoke();
    }


}
