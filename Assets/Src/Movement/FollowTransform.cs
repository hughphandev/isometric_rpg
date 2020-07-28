using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTransform : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    private MovableDirect mover;

    private void Awake() {
        mover = GetComponent<MovableDirect>();
    }

    private void Update() {
        mover.MoveTo(target.position + offset);
    }
}
