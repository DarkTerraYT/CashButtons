using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models;
using Il2CppAssets.Scripts.Models.Bloons;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Weapons.Behaviors;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Unity.Display;
using Il2CppAssets.Scripts.Unity.Towers.Behaviors;
using Il2CppAssets.Scripts.Utils;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Linq;

namespace CashButton
{ 
    // This is the Button that gives you cash
    internal class AddCashButton : ModTower
    {
        public override string BaseTower => TowerType.DartMonkey;

        public override int Cost => 0;

        public override int TopPathUpgrades => 0;

        public override int MiddlePathUpgrades => 0;

        public override int BottomPathUpgrades => 0;

        public override string Icon => "AddCashButtonDisplay";

        public override string Portrait => "AddCashButtonDisplay";

        public override string Description => "Gives you money";

        public override TowerSet TowerSet => TowerSet.Support;

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.RemoveBehavior(towerModel.GetAttackModel());
            towerModel.range = 1f;
            var behaviors = new Il2CppReferenceArray<Model>(1);
            behaviors[0] = new ImfLoanModel("GiveCash", CashButtonMod.CashOnAbilityUse, 0f, new PrefabReference(), 1);
            var abilityModel = new AbilityModel("giveCash_", "Cash Drop", "Gives the Player the Number of Cash set in the Config", 0, 0, GetSpriteReference(Icon),
                0f, behaviors, false, false, null, 0, 0, -1, true, false);
            towerModel.AddBehavior(abilityModel);
        }
    }

    // The Display for the tower above
    internal class AddCashButtonDisplay : ModTowerDisplay<AddCashButton>
    {
        public override string BaseDisplay => Generic2dDisplay;
        public override bool UseForTower(int[] tiers)
        {
            return tiers.Max() < 1;
        }
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, Name);
        }
    }

    // This is the Button that gives you cash
    internal class AddCashButton10x : ModTower
    {
        public override string BaseTower => TowerType.DartMonkey;

        public override int Cost => 0;

        public override int TopPathUpgrades => 0;

        public override int MiddlePathUpgrades => 0;

        public override int BottomPathUpgrades => 0;

        public override string Icon => "AddCashButton10xDisplay";

        public override string Portrait => "AddCashButton10xDisplay";

        public override string Description => "Gives you 10x the amount of the normal one";

        public override TowerSet TowerSet => TowerSet.Support;

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.RemoveBehavior(towerModel.GetAttackModel());
            towerModel.range = 1f;
            var behaviors = new Il2CppReferenceArray<Model>(1);
            behaviors[0] = new ImfLoanModel("GiveCash", CashButtonMod.CashOnAbilityUse * 10, 0f, new PrefabReference(), 1);
            var abilityModel = new AbilityModel("giveCash2_", "Cash Drop 10x", "Gives the Player the Number of Cash set in the Config x 10", 0, 0, GetSpriteReference(Icon),
                0f, behaviors, false, false, null, 0, 0, -1, true, false);
            towerModel.AddBehavior(abilityModel);
        }
    }

    // The Display for the tower above
    internal class AddCashButton10xDisplay : ModTowerDisplay<AddCashButton10x>
    {
        public override string BaseDisplay => Generic2dDisplay;
        public override bool UseForTower(int[] tiers)
        {
            return tiers.Max() < 1;
        }
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, Name);
        }
    }

    internal class AddCashButton100x : ModTower
    {
        public override string BaseTower => TowerType.DartMonkey;

        public override int Cost => 0;

        public override int TopPathUpgrades => 0;

        public override int MiddlePathUpgrades => 0;

        public override int BottomPathUpgrades => 0;

        public override string Icon => "AddCashButton100xDisplay";

        public override string Portrait => "AddCashButton100xDisplay";

        public override string Description => "Gives you 100x the amount of the normal one";

        public override TowerSet TowerSet => TowerSet.Support;

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.RemoveBehavior(towerModel.GetAttackModel());
            towerModel.range = 1f;
            var behaviors = new Il2CppReferenceArray<Model>(1);
            behaviors[0] = new ImfLoanModel("GiveCash", CashButtonMod.CashOnAbilityUse * 100, 0f, new PrefabReference(), 1);
            var abilityModel = new AbilityModel("giveCash3_", "Cash Drop 100x", "Gives the Player the Number of Cash set in the Config x 10", 0, 0, GetSpriteReference(Icon),
                0f, behaviors, false, false, null, 0, 0, -1, true, false);
            towerModel.AddBehavior(abilityModel);
        }
    }

    // The Display for the tower above
    internal class AddCashButton100xDisplay : ModTowerDisplay<AddCashButton100x>
    {
        public override string BaseDisplay => Generic2dDisplay;
        public override bool UseForTower(int[] tiers)
        {
            return tiers.Max() < 1;
        }
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, Name);
        }
    }

    internal class SetCashButton : ModTower
    {
        public override TowerSet TowerSet => TowerSet.Support;

        public override string BaseTower => TowerType.DartMonkey;

        public override int Cost => 0;

        public override int TopPathUpgrades => 0;

        public override int MiddlePathUpgrades => 0;

        public override int BottomPathUpgrades => 0;

        public override string Icon => "SetCashButtonDisplay";

        public override string Portrait => "SetCashButtonDisplay";

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.RemoveBehavior(towerModel.GetAttackModel());
            towerModel.range = 1f;

            var abilityModel = new AbilityModel("setCash", "Set Cash", "Sets The Cash to the Number in the Config", 0, 0, GetSpriteReference(Icon),
                0f, null, false, false, null, 0, 0, -1, true, false);
            towerModel.AddBehavior(abilityModel);
        }
    }

    // The Display for the tower above
    internal class SetCashButtonDisplay : ModTowerDisplay<SetCashButton>
    {
        public override string BaseDisplay => Generic2dDisplay;
        public override bool UseForTower(int[] tiers)
        {
            return tiers.Max() < 1;
        }
        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            Set2DTexture(node, Name);
        }
    }
}
