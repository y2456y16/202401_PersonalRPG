using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XY_Attack : MonoBehaviour //not completed
{
    private XY_CharacterController _controller;

    [SerializeField] private Transform projectileSpawnPosition;

    private Vector2 _aimDirection = Vector2.right;
    public GameObject testPrefab;

    private void Awake()
    {
        _controller = GetComponent<XY_CharacterController>();
    }
    

    void Start()
    {
        _controller.AttackEvent += OnShoot;
        _controller.LookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        _aimDirection = newAimDirection;
    }

    private void OnShoot()
    {
        CreateProjectile();
    }

    private void CreateProjectile()
    {
        //Instantiate(testPrefab, projectileSpawnPosition.position, Quaternion.identity);
    }

    void Update()
    {
        
    }
}
