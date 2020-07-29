using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpPosition : MonoBehaviour, MovableDirect
{
    [SerializeField] private float delay;
    private float speed;
    private bool canMove;

    private void Start()
    {
        if (delay != 0)
        {
            speed = 1f / delay;
        }
        else
        {
            speed = Mathf.Infinity;
        }
        canMove = true;
    }
    public void MoveTo(Vector3 position)
    {
        if (canMove)
            transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime * speed);
    }

    public void Pause()
    {
        canMove = false;
    }

    public void Continue()
    {
        canMove = true;
    }
}
