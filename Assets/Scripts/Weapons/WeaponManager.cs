using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] private List<BaseWeapon> availableWeapons;
    [SerializeField] private Button fireButton;
    [SerializeField] private Button iceButton;
    [SerializeField] private Button electricButton;

    private BaseWeapon currentWeapon;

    public UnityEvent attackEvent = null;
    private void Start()
    {
        SetupButtons();
        // Equip first weapon by default
        if (availableWeapons.Count > 0)
        {
            SwitchWeapon(availableWeapons[0]);
        }
    }

    private void SetupButtons()
    {
        fireButton?.onClick.AddListener(() => SwitchToWeaponType(WeaponType.Fire));
        iceButton?.onClick.AddListener(() => SwitchToWeaponType(WeaponType.Ice));
        electricButton?.onClick.AddListener(() => SwitchToWeaponType(WeaponType.Electric));
    }

    public void SwitchToWeaponType(WeaponType type)
    {
        BaseWeapon weapon = availableWeapons.Find(w => w.Type == type);
        if (weapon != null)
        {
            SwitchWeapon(weapon);
        }
    }

    private void SwitchWeapon(BaseWeapon newWeapon)
    {
        if (currentWeapon != null)
        {
            currentWeapon.OnUnequip();
        }

        currentWeapon = newWeapon;
        currentWeapon.OnEquip();

        Debug.Log($"Switched to {currentWeapon.WeaponName}");
    }

    public void Attack()
    {
        if (!currentWeapon.CanAttack()) return;

        attackEvent.Invoke();
        currentWeapon?.Attack();
    }
}
