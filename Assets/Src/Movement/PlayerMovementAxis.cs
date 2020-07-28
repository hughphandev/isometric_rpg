using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementAxis : MonoBehaviour
{
    private Movable mover;
    private Turnable turner;

    private void Awake()
    {
        mover = GetComponent<Movable>();
        turner = GetComponent<Turnable>();
    }

    private void Update()
    {
        Vector3 moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical")).normalized;
        mover.Move(moveDir);

        if(moveDir.x != 0 || moveDir.z != 0)
        {
            turner.Turn(Mathf.Atan2(moveDir.x, moveDir.z) * Mathf.Rad2Deg);
        }
    }
}
