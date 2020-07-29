using UnityEngine;


[CreateAssetMenu(fileName = "ProjectileAbility", menuName = "Ability/ProjectileAbility", order = 0)]
public class ProjectileAbility : Ability
{
    public GameObject projectile;

    public override string Type => "Projectile";

}