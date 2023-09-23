using MelonLoader;
using BTD_Mod_Helper;
using CashButton;
using BTD_Mod_Helper.Api.ModOptions;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Unity.UI_New.InGame;

[assembly: MelonInfo(typeof(CashButtonMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace CashButton;

public class CashButtonMod : BloonsTD6Mod
{
    public static readonly ModSettingInt CashOnAbilityUse = new(2500)
    {
        requiresRestart = true,
        description = "How much cash you get when you use the ability, default is 2500 or 1 cashdrop"
    };

    public static readonly ModSettingInt CashSetOnAbilityUse = new(25000)
    {
        requiresRestart = true,
        description = "What your cash gets set to when you use the ability on the second button"
    };

    public override void OnAbilityCast(Ability ability)
    {
        bool flag = ability.abilityModel.displayName.Contains("Set Cash");

        if (flag)
        {
            InGame.instance.bridge.SetCash(CashSetOnAbilityUse);
        }
    }
}