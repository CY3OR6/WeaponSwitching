using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceWeapon : BaseWeapon
{
    public override string WeaponName => "Ice Staff";
    public override WeaponType Type => WeaponType.Ice;

    public override void Attack()
    {
        base.Attack();
        // Add ice-specific attack logic here
        Debug.Log($"Ice attack dealing {damage} damage!");
    }
}
