﻿using BannerlordCheats.Settings;
using HarmonyLib;
using SandBox;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BannerlordCheats.Patches
{
    [HarmonyPatch(typeof(SandboxAgentApplyDamageModel), "CalculateDamage")]
    public static class SandboxAgentApplyDamageModelPatch
    {
        [HarmonyPostfix]
        public static void CalculateDamage(BasicCharacterObject affectorBasicCharacter, BasicCharacterObject affectedBasicCharacter, MissionWeapon offHandItem, bool isHeadShot, bool isAffectedAgentMount, bool isAffectedAgentHuman, bool hasAffectorAgentMount, bool isAffectedAgentNull, bool isAffectorAgentHuman, AttackCollisionData collisionData, WeaponComponentData weapon, ref int __result)
        {
            if ((affectedBasicCharacter?.IsPlayerCharacter ?? false) && BannerlordCheatsSettings.Instance.Invincible)
            {
                __result = 0;
            }
        }
    }
}