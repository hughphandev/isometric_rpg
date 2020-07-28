using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByController : MonoBehaviour, Movable
{
    [SerializeField] private float speed;
    private Turnable turner;

    private CharacterController controller;
    private Vector3 moveDir;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        turner = GetComponent<Turnable>();
    }

    public void Move(Vector3 dir)
    {
        moveDir = dir;
        controller.Move(moveDir * speed * Time.deltaTime);
    }
}
