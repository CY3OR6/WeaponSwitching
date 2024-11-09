# WeaponSwitching
# Modular Weapon System for Unity3D

A flexible and extensible weapon system implementation using Object-Oriented Programming principles. The system supports different weapon types with unique projectiles and VFX, making it easy to add new weapons while maintaining clean, maintainable code.

## Design Philosophy

This system is built on solid OOP principles to ensure maintainability, extensibility, and reusability:

### 1. Abstraction
- `IWeapon` interface defines the contract for all weapons
- `BaseWeapon` abstract class provides common functionality
- Each concrete weapon implementation focuses on unique behaviors

### 2. Encapsulation
- Weapon properties and behaviors are encapsulated within their respective classes
- Internal weapon state is protected from external modification

### 3. Inheritance
```
IWeapon (Interface)
└── BaseWeapon (Abstract Class)
    ├── FireWeapon
    ├── IceWeapon
    └── ElectricWeapon
```

### 4. Polymorphism
- Different weapon types can be treated uniformly through the `IWeapon` interface
- Each weapon type can override base behavior while maintaining common functionality
- Runtime weapon switching is seamless due to polymorphic behavior

## Architecture Overview

### Core Components

   - `IWeapon`: Core weapon interface
   - `BaseWeapon`: Abstract base implementation
   - Concrete weapon classes (Fire, Ice, Electric)
   - `WeaponManager`: Handles weapon switching and control

## Design Patterns Used

1. **Strategy Pattern**
   - Different weapon behaviors can be swapped at runtime
   - Weapon types are interchangeable through common interface

2. **Template Method Pattern**
   - `BaseWeapon` defines the skeleton of operations
   - Concrete weapons override specific methods while maintaining common structure

3. **Observer Pattern**
   - Weapon system events can be observed for UI updates
   - VFX responses to weapon actions


## Best Practices

1. **Single Responsibility Principle**
   - Each class has a single, well-defined purpose

2. **Open/Closed Principle**
   - System is open for extension (new weapons) but closed for modification
   - Base functionality remains stable while adding features

3. **Dependency Inversion**
   - High-level modules depend on abstractions
   - Easy to swap implementations without changing core logic

4. **Interface Segregation**
   - Clean interfaces with minimal required methods
   - No unnecessary dependencies

## Performance Considerations

1. **Object Pooling**
   - Reduce garbage collection overhead

2. **VFX Optimization**
   - Limit particle count based on platform

## Usage Example

```csharp
// Get weapon manager reference
WeaponManager weaponManager = GetComponent<WeaponManager>();

// Switch weapons
weaponManager.SwitchToWeaponType(WeaponType.Fire);

// Attack
weaponManager.Attack();
```

## Dependencies

- Unity 2021.3 or higher
- VFX Graph package
- Universal RP or HDRP (for VFX Graph support)

## License

This project is licensed under the MIT License - see the LICENSE file for details.
 
