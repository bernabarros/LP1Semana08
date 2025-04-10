```mermaid

---
title: MiniGame
---
classDiagram

Weapon <-- Character
class Character{
    #Weapon[] weapons
    +string Name
    +void Fight()
}

Character <|--Player
class Player

Character <|--Enemy
class Enemy

class Weapon{
    #float power
}
Weapon <|--Sword
class Sword{
    +float BladeLength
    +void AttackWithSword()
}
Weapon <|--Gun
class Gun{
    +int Ammo
    +void FireGun()
}
Character <-- Main
class Main{
    Character[] characters
    -void Main()
}

