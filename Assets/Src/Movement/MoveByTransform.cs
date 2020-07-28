using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByTransform : MonoBehaviour, Movable
{
    [SerializeField] private float speed;

    public void Move(Vector3 moveDir)
    {
        transform.Translate(moveDir * speed * Time.deltaTime);
    }

}
