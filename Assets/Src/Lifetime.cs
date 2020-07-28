using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    [SerializeField] private float lifeTime;
    private float timer;

    private void Start()
    {
        timer = lifeTime;
    }

    private void Update()
    {
        if (timer <= 0)
            Destroy(gameObject);
        else
            timer -= Time.deltaTime;
    }
}
