using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpPosition : MonoBehaviour, MovableDirect
{
    [SerializeField] private float delay;
    private float speed;

    private void Start() {
        if(delay != 0)
        {
            speed = 1f / delay;
        }
        else
        {
            speed = Mathf.Infinity;
        }
    }
    public void MoveTo(Vector3 position)
    {
        transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime * speed);
    }
}
