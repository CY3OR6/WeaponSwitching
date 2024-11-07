using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : BaseWeapon
{
    public override string WeaponName => "Fire Staff";
    public override WeaponType Type => WeaponType.Fire;

    public override void Attack()
    {
        base.Attack();
        // Add fire-specific attack logic here
        Debug.Log($"Fire attack dealing {damage} damage!");
    }
}
