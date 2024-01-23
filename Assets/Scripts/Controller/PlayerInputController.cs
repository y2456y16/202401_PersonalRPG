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

    //Input action에서 move로 설정한 키들을 입력 시 작동
    //vector2 값으로 반환되며, 이동거리를 좌표값으로 표현. (예, -1.00, 0.00)
    //normalized란 이동 벡터 값이 1이 되도록 계산 (에, 우측 하나만 누르면 1.00,0.00인데 위 방향키도 같이 누르면 0.7,0.7로 나옴)
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;//대각선이면 약 0.7,0.7

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

    //Input action에서 Look으로 설정된 키들을 입력 시 작동 (mouse 위치)
    //Vector2 값으로 변환됨 (예, 400.00, 420.00)
    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);//월드좌표값으로 전환
        newAim = (worldPos - (Vector2)transform.position).normalized;
        //(Vector2)transform.position이란 이 c# 파일이 연결된 오브젝트의 월드좌표값을 Vector2 값으로 가져온 것을 의미

        //마우스의 위치와 player의 위치가 미세하게라도 다르기에 오브젝트가 떨리는 버그가 발생할 수 있기에 특정 거리 미만이면 동일하게 인식되도록 작업
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