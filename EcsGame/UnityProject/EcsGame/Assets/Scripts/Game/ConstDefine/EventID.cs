using UnityEngine;
using System.Collections;
using GameFrame;

namespace Game.Logic
{
    public enum EventID
    {
        OnLanguageTableSwitchFinish,

        OnAddCoinNum,
        OnAddDiamondNum,

        OnUpdateItemNumber,
        #region UI
        OnSelectHeroEquipBtnClicked,
        OnSelectShipEquipBtnClicked,
        #endregion
        #region Player
        OnUpdatePlayerExp,
        #endregion
        #region Battle
        OnHeroDataChanged,
        OnShipBuildingBoardStateChanged,
        OnBattleGainExp,
        OnCheckLevelUpPoint,
        OnArtifactSelected,
        OnBossKilled,
        OnEnemyKilledByWeapon,
        OnEnemyKilledByShip,
        OnAllHeroDead,
        OnCageDestroyed,
        OnGetNewReform,
        OnAddNewHero,
        #endregion
    }

}
