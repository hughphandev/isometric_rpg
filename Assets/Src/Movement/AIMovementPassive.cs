using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovementPassive : MonoBehaviour
{
    [SerializeField] private float detectRange;
    [SerializeField] private float attackRange;
    [SerializeField] private string targetTag;
    [SerializeField] private float interval;
    private Movable mover;
    private Transform target;

    private void Awake()
    {
        mover = GetComponent<Movable>();
    }

    private void Start()
    {
        StartCoroutine(UpdateTransformDelay());
    }

    private void Update()
    {
        if (target != null)
        {
            Vector3 deltaPos = (target.position - transform.position);
            if (deltaPos.magnitude > attackRange)
            {
                mover.Move(deltaPos.normalized);
            }
        }
    }

    private IEnumerator UpdateTransformDelay()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, detectRange);
        foreach (Collider c in cols)
        {
            if (c.CompareTag(targetTag))
            {
                target = c.transform;
                break;
            }
            target = null;
        }
        yield return new WaitForSeconds(interval);
        StartCoroutine(UpdateTransformDelay());
    }
}
