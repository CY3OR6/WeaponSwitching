using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseWeapon : MonoBehaviour, IWeapon
{
    [SerializeField] protected float damage;
    [SerializeField] protected float cooldown;
    [SerializeField] protected ParticleSystem weaponEffect;

    protected bool canAttack = true;

    public abstract string WeaponName { get; }
    public abstract WeaponType Type { get; }

    public virtual void Attack()
    {
        if (!canAttack) return;

        //StartCoroutine(AttackCooldown());
        PlayWeaponEffect();
    }

    public virtual void OnEquip()
    {
        gameObject.SetActive(true);
    }

    public virtual void OnUnequip()
    {
        canAttack = true;
        gameObject.SetActive(false);
    }

    protected virtual void PlayWeaponEffect()
    {
        if (weaponEffect != null)
        {
            weaponEffect.Play();
        }
    }

    private IEnumerator AttackCooldown()
    {
        canAttack = false;
        yield return new WaitForSeconds(cooldown);
        canAttack = true;
    }

    public bool CanAttack()
    {
        return canAttack;
    }
}
