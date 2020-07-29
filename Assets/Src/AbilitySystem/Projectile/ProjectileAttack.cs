using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileAttack : MonoBehaviour, Attackable
{
    [SerializeField] private Transform attackTransform;
    [SerializeField] private Transform body;
    private GameObject projectile;
    private Camera cam;

    public GameObject Projectile { get => projectile; set => projectile = value; }

    private void Start()
    {
        cam = Camera.main;
    }

    private void LaunchProjectile()
    {
        GameObject p = Instantiate(projectile, attackTransform.position, attackTransform.rotation);
        p.tag = tag;
    }

    public IEnumerator Attack(float delay)
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        new Plane(Vector3.up, transform.position).Raycast(ray, out float enter);
        Vector3 dir = ray.GetPoint(enter) - transform.position;
        float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
        body.eulerAngles = new Vector3(0, angle, 0);

        yield return new WaitForSeconds(delay);

        LaunchProjectile();
    }
}
