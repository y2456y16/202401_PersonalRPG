using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : XY_CharacterController
{
    private Camera _camera;

    [SerializeField] private SpriteRenderer characterRenderer;

    private void Awake()
    {
        _camera = Camera.main;
    }

    protected void FixedUpdate()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        _camera.transform.position = new Vector3(x, y,-10);
    }

    //Input action���� move�� ������ Ű���� �Է� �� �۵�
    //vector2 ������ ��ȯ�Ǹ�, �̵��Ÿ��� ��ǥ������ ǥ��. (��, -1.00, 0.00)
    //normalized�� �̵� ���� ���� 1�� �ǵ��� ��� (��, ���� �ϳ��� ������ 1.00,0.00�ε� �� ����Ű�� ���� ������ 0.7,0.7�� ����)
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;//�밢���̸� �� 0.7,0.7

        if(moveInput.x <0)
        {
            characterRenderer.flipX = true;
        }
        else if(moveInput.x > 0)
        {
            characterRenderer.flipX =false;
        }

        CallMoveEvent(moveInput);
    }

    //Input action���� Look���� ������ Ű���� �Է� �� �۵� (mouse ��ġ)
    //Vector2 ������ ��ȯ�� (��, 400.00, 420.00)
    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);//������ǥ������ ��ȯ
        newAim = (worldPos - (Vector2)transform.position).normalized;
        //(Vector2)transform.position�̶� �� c# ������ ����� ������Ʈ�� ������ǥ���� Vector2 ������ ������ ���� �ǹ�

        //���콺�� ��ġ�� player�� ��ġ�� �̼��ϰԶ� �ٸ��⿡ ������Ʈ�� ������ ���װ� �߻��� �� �ֱ⿡ Ư�� �Ÿ� �̸��̸� �����ϰ� �νĵǵ��� �۾�
        if (newAim.magnitude >= .9f)
        {
            float rotZ = Mathf.Atan2(newAim.y, newAim.x) * Mathf.Rad2Deg;
            characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
            CallLookEvent(newAim);
        }
    }

    public void OnFire(InputValue value)
    {
        IsAttacking = value.isPressed;
    }

}