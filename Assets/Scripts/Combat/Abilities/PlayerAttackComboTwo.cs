﻿using UnityEngine;

namespace DigitalMedia.Combat.Abilities
{
    [CreateAssetMenu(menuName = "Abilities/Player/Combo Two", fileName = "Player_Combo_Two")]
    public class PlayerAttackComboTwo : AbilityBase
    {
        [Header("Attack Range")]
        [SerializeField] private Vector2 weaponOffset; 
        [SerializeField] private Vector2 weaponRange; 
        
        public override void Activate(GameObject holder)
        {
            holder.GetComponent<PlayerCombatSystem>()?.HandleBasicAttack(weaponOffset, weaponRange);
            holder.GetComponent<PlayerCombatSystem>().currentAttackIndex++;
            //Play audio 
            //Play Effects 
        }
    }
}