using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackMouse : MonoBehaviour
{
    private Attackable attacker;
    private Camera cam;

    private void Awake()
    {
        attacker = GetComponent<Attackable>();
        cam = Camera.main;
    }

    private void LateUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            new Plane(Vector3.up, transform.position).Raycast(ray, out float enter);
            Vector3 dir = ray.GetPoint(enter) - transform.position;
            float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, angle, 0);
            attacker.Attack(0);
        }
    }
}
