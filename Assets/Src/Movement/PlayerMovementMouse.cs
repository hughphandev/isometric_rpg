using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementMouse : MonoBehaviour
{
    private MovableDirect mover;
    private Camera cam;

    private void Awake() {
        mover = GetComponent<MovableDirect>();
    }

    private void Start() {
        cam = Camera.main;
    }

    private void Update() {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            new Plane(Vector3.up, transform.position).Raycast(ray, out float enter);
            mover.MoveTo(ray.GetPoint(enter));
        }
    }
}
