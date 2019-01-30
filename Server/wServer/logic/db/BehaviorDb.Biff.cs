﻿using wServer.logic.behaviors;
using wServer.logic.loot;
using wServer.logic.transitions;
using common.resources;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ Biff = () => Behav()
            .Init("BB Biff the Buffed Bunny",
            new State(
                new ScaleHP(8000),
                new State("Taunt+INV",
                    new Taunt("You have stolen and broken eggs at your leisure. I will put a stop to this!"),
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable, duration: 0),
                    new TimedTransition(3000, "AttackingNumber1")
                    ),
                new State("AttackingNumber1",
                    new Wander(0.1),
                    new Shoot(20, 10, 15, 0, 90, coolDown: 6000, coolDownOffset: 3000),
                    new Shoot(20, 10, 15, 0, 270, coolDown: 6000, coolDownOffset: 3000),
                    new Shoot(20, 10, 15, 0, 360, coolDown: 6000, coolDownOffset: 6000),
                    new Shoot(20, 10, 15, 0, 180, coolDown: 6000, coolDownOffset: 6000),
                    new Shoot(20, 1, projectileIndex: 3, predictive: 0.1, coolDown: 5000),
                    new HpLessTransition(.8, "CrazyBitchGoingHam")
                    ),
                new State("CrazyBitchGoingHam",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable, duration: 3000),
                    new Shoot(22, 12, 30, 4, 360, coolDown: 2500),
                    new Shoot(20, 3, 25, 1, predictive: 0.1, coolDown: 1000, coolDownOffset: 500),
                    new Shoot(20, 2, 15, 1, predictive: 0.1, coolDown: 1000, coolDownOffset: 1000),
                    new HpLessTransition(.5, "JUSTSTFUANDGOSHOPATIKEA")
                    ),
                new State("JUSTSTFUANDGOSHOPATIKEA",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable, duration: 3000),
                    new Shoot(20, 20, 13.5, 5, 30, coolDown: 12000, coolDownOffset: 1000),
                    new Shoot(20, 20, 13.5, 5, 60, coolDown: 12000, coolDownOffset: 2000),
                    new Shoot(20, 20, 13.5, 5, 90, coolDown: 12000, coolDownOffset: 3000),
                    new Shoot(20, 20, 13.5, 5, 120, coolDown: 12000, coolDownOffset: 4000),
                    new Shoot(20, 20, 13.5, 5, 150, coolDown: 12000, coolDownOffset: 5000),
                    new Shoot(20, 20, 13.5, 5, 180, coolDown: 12000, coolDownOffset: 6000),
                    new Shoot(20, 20, 13.5, 5, 210, coolDown: 12000, coolDownOffset: 7000),
                    new Shoot(20, 20, 13.5, 5, 240, coolDown: 12000, coolDownOffset: 8000),
                    new Shoot(20, 20, 13.5, 5, 270, coolDown: 12000, coolDownOffset: 9000),
                    new Shoot(20, 20, 13.5, 5, 300, coolDown: 12000, coolDownOffset: 10000),
                    new Shoot(20, 20, 13.5, 5, 330, coolDown: 12000, coolDownOffset: 11000),
                    new Shoot(20, 20, 13.5, 5, 360, coolDown: 12000, coolDownOffset: 12000),
                    new Shoot(20, 3, 10, 2, predictive: 0.1, coolDown: 700),
                    new HpLessTransition(.2, "OKAYIMFUCKINGMADGOFUCKURSELFUBITCH")
                    ),
                new State("OKAYIMFUCKINGMADGOFUCKURSELFUBITCH",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable, duration: 2000),
                    new Shoot(25, 36, 10, 1, 360, coolDown: 3000),
                    new Shoot(20, projectileIndex: 5, count: 5, shootAngle: 12, fixedAngle: 0, coolDown: 1800, coolDownOffset: 800),
                    new Shoot(20, projectileIndex: 5, count: 5, shootAngle: 12, fixedAngle: 90, coolDown: 1800, coolDownOffset: 800),
                    new Shoot(20, projectileIndex: 5, count: 5, shootAngle: 12, fixedAngle: 180, coolDown: 1800, coolDownOffset: 800),
                    new Shoot(20, projectileIndex: 5, count: 5, shootAngle: 12, fixedAngle: 270, coolDown: 1800, coolDownOffset: 800),
                    new Shoot(20, projectileIndex: 5, count: 5, shootAngle: 12, fixedAngle: 45, coolDown: 1800, coolDownOffset: 1800),
                    new Shoot(20, projectileIndex: 5, count: 5, shootAngle: 12, fixedAngle: 135, coolDown: 1800, coolDownOffset: 1800),
                    new Shoot(20, projectileIndex: 5, count: 5, shootAngle: 12, fixedAngle: 225, coolDown: 1800, coolDownOffset: 1800),
                    new Shoot(20, projectileIndex: 5, count: 5, shootAngle: 12, fixedAngle: 315, coolDown: 1800, coolDownOffset: 1800)
                    )
                ),
                new Threshold(0.1,
                    new ItemLoot("Potion of Attack", 0.25)
                    ),
                new Threshold(0.025,
                    new ItemLoot("Dagger of the Hasteful Rabbit", 0.05),
                    new ItemLoot("Potion of Attack", 0.05),
                    new ItemLoot("Potion of Defense", 0.05),
                    new ItemLoot("Potion of Vitality", 0.05),
                    new ItemLoot("Potion of Dexterity", 0.05),
                    new ItemLoot("Potion of Wisdom", 0.05),
                    new ItemLoot("Potion of Speed", 0.05),
                    new ItemLoot("Vitamine Buster", 0.005),
                    new ItemLoot("Helm of the Swift Bunny", 0.005)
                )
            )
    ;
    }
}
