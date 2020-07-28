using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityController : MonoBehaviour
{
    [SerializeField] private KeyCode activateKey;

    [SerializeField] private Ability ability;
    [SerializeField] private Transform weapon;

    private AudioSource audioSource;
    private float coolDown;
    private float coolDownRemain;
    private Attackable attacker;

    public Ability Ability { get => ability; set => ability = value; }
    public float CoolDownRemain { get => coolDownRemain; }
    public float CoolDown { get => coolDown; set => coolDown = value; }

    private void Start()
    {
        Initialize(ability);
    }

    private void Update()
    {
        if (coolDownRemain <= 0f)
        {
            if (Input.GetKeyDown(activateKey))
            {
                ButtonTriggered();
            }
        }
        else
        {
            TickCoolDown();
        }
    }

    public void Initialize(Ability ability)
    {
        this.ability = ability;

        coolDown = ability.coolDown;
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = ability.sound;
        InitWeapon();
    }

    private void InitWeapon()
    {
        switch(ability.Type)
        {
            case "Projectile":
            attacker = weapon.GetComponent<ProjectileAttack>();
            (attacker as ProjectileAttack).Projectile = (ability as ProjectileAbility).projectile;
            break;
        }
    }
    private void TickCoolDown()
    {
        coolDownRemain -= Time.deltaTime;
    }

    private void ButtonTriggered()
    {
        coolDownRemain = coolDown;
        audioSource.Play();
        attacker.Attack();
    }
}
