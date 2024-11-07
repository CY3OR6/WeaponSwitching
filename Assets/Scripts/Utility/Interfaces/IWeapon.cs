public interface IWeapon
{
    string WeaponName { get; }
    WeaponType Type { get; }
    void Attack();
    void OnEquip();
    void OnUnequip();
}
