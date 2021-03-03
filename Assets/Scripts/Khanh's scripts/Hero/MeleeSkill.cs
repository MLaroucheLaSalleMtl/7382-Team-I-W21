using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeleeSkill : Skill
{
    private int weaponAttackDamageIncrease;
    private int meleeAttackRange;

    public MeleeSkill(int attackRange, int attackDamageIncrease) : base(attackRange, attackDamageIncrease)
    {
        attackRange = this.meleeAttackRange;
        attackDamageIncrease = weaponAttackDamageIncrease;
    }

    private void PowerStrike(int skillDamage, int attackRange)
    {
        skillDamage = weaponAttackDamageIncrease * 2;
        attackRange = meleeAttackRange;
    }

}
