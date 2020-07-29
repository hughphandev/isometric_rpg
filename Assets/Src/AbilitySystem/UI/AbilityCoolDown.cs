using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityCoolDown : MonoBehaviour
{
    [SerializeField] AbilityController ability;
    [SerializeField] private Image icon;
    [SerializeField] private Image cover;
    [SerializeField] private Text cdrRemainText;

    public void Init(Ability ability)
    {
        icon.sprite = ability.icon;
        cover.sprite = ability.icon;
    }

    private void Start()
    {
        Init(ability.Ability);
        icon.enabled = true;
    }

    private void Update()
    {
        if (ability.CoolDownRemain > 0)
        {
            cover.enabled = true;
            cdrRemainText.enabled = true;
            cdrRemainText.text = Mathf.Round(ability.CoolDownRemain).ToString();
            cover.fillAmount = (ability.CoolDownRemain / ability.CoolDown);
        }
        else
        {
            cover.enabled = false;
            cdrRemainText.enabled = false;
        }
    }
}
