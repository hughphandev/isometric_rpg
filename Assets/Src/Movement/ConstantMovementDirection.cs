using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMovementDirection : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    private Movable mover;

    private void Awake()
    {
        mover = GetComponent<Movable>();
    }

    private void Update()
    {
        mover.Move(direction);
    }
}
