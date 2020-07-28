using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private float range;

    private void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, range);
        foreach (Collider c in colliders)
        {
            Damagable damagable = c.GetComponent<Damagable>();
            if (damagable != null && !c.CompareTag(tag))
            {
                damagable.TakeDame(damage);
                Destroy(gameObject);
            }
        }
    }
}
