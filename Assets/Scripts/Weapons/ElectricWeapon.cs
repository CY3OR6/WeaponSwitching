using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricWeapon : BaseWeapon
{
    public override string WeaponName => "Lightning Staff";
    public override WeaponType Type => WeaponType.Electric;

    public override void Attack()
    {
        base.Attack();
        // Add electric-specific attack logic here
        Debug.Log($"Electric attack dealing {damage} damage!");
    }
}
