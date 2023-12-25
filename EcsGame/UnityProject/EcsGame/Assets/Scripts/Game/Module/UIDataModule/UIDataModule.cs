using UnityEngine;
using System.Collections;
using GameFrame;

namespace Game.Logic
{
    public class UIDataModule : AbstractModule
    {
        public static void RegisterStaticPanel()
        {
            InitUIPath();
            UIDataTable.SetABMode(false);

            UIDataTable.AddPanelData(UIID.LogoPanel, null, "LogoPanel/LogoPanel");
        }

        protected override void OnComAwake()
        {
            InitUIPath();
            RegisterAllPanel();
        }

        private static void InitUIPath()
        {
            PanelData.PREFIX_PATH = "Resources/UI/Panels/{0}";
            PageData.PREFIX_PATH = "Resources/UI/Panels/{0}";
        }

        private void RegisterAllPanel()
        {
            UIDataTable.SetABMode(true);

            UIDataTable.AddPanelData(EngineUI.FloatMessagePanel, null, "Common/FloatMessagePanel", true, 1);
            //UIDataTable.AddPanelData(UIID.FloatMessagePanel1, null, "Common/FloatMessagePanel1", true, 1);
            UIDataTable.AddPanelData(EngineUI.MsgBoxPanel, null, "Common/MsgBoxPanel", true, 1);
            UIDataTable.AddPanelData(EngineUI.HighlightMaskPanel, null, "Guide/HighlightMaskPanel", true, 0);
            //UIDataTable.AddPanelData(EngineUI.GuideHandPanel, null, "Guide/GuideHandPanel", true, 0);
            UIDataTable.AddPanelData(EngineUI.MaskPanel, null, "Common/MaskPanel", true, 1);
            UIDataTable.AddPanelData(EngineUI.ColorFadeTransition, null, "Common/ColorFadeTransition", true, 1);
            //UIDataTable.AddPanelData(SDKUI.AdDisplayer, null, "Common/AdDisplayer", false, 1);
            //UIDataTable.AddPanelData(SDKUI.OfficialVersionAdPanel, null, "OfficialVersionAdPanel");
            //UIDataTable.AddPanelData(EngineUI.RatePanel,null,"Common/RatePanel");


            //effect panel
            UIDataTable.AddPanelData(UIID.UIParticalPanel, null, "Common/UIParticalPanel");

            //在开发阶段使用该模式方便调试
            UIDataTable.SetABMode(false);

            //guide
            UIDataTable.AddPanelData(UIID.GuideWordsPanel, null, "GuidePanel/GuideWordsPanel");
            UIDataTable.AddPanelData(UIID.GuideUIClipPanel, null, "GuidePanel/GuideUIClipPanel");
            UIDataTable.AddPanelData(EngineUI.GuideHandPanel, null, "GuidePanel/GuideHandPanel");

            //Lobby
            UIDataTable.AddPanelData(UIID.MainMenuPanel, null, "GamePanels/MainMenuPanel/MainMenuPanel", true, 1);
            UIDataTable.AddPanelData(UIID.TopInfoPanel, null, "GamePanels/MainMenuPanel/TopInfoPanel", true, 1);
            UIDataTable.AddPanelData(UIID.SettingPanel, null, "GamePanels/MainMenuPanel/SettingPanel", true, 1);
            //UIDataTable.AddPanelData(UIID.LobbyPanel, null, "GamePanels/LobbyPanel/LobbyPanel", true ,1);
            //UIDataTable.AddPanelData(UIID.ShopPanel, null, "GamePanels/ShopPanel/ShopPanel", true, 1);
            UIDataTable.AddPanelData(UIID.LoadingPanel, null, "GamePanels/LoadingPanel/LoadingPanel", true, 1);
            UIDataTable.AddPanelData(UIID.SceneTransitionPanel, null, "GamePanels/SceneTransitionPanel/SceneTransitionPanel", true, 1);
            //UIDataTable.AddPanelData(UIID.SelectHeroAndShipPanel, null, "GamePanels/SelectHeroAndShipPanel/SelectHeroAndShipPanel", true, 1);
            UIDataTable.AddPanelData(UIID.CaptainDetailPanel, null, "GamePanels/MainMenuPanel/SelectHeroAndShipPanel/CaptainDetailPanel", true, 1);
            UIDataTable.AddPanelData(UIID.ShipDetailPanel, null, "GamePanels/MainMenuPanel/SelectHeroAndShipPanel/ShipDetailPanel", true, 1);
            UIDataTable.AddPanelData(UIID.TalentDetailPanel, null, "GamePanels/TalentPanel/TalentDetailPanel", true, 1);
            //Battle
            UIDataTable.AddPanelData(UIID.BattlePanel, null, "GamePanels/BattlePanel/BattlePanel", true, 1);
            UIDataTable.AddPanelData(UIID.GMPanel, null, "GamePanels/BattlePanel/GMPanel", true, 1);
            UIDataTable.AddPanelData(UIID.BattleTipPanel, null, "GamePanels/BattlePanel/BattleTipPanel", true, 1);
            UIDataTable.AddPanelData(UIID.BattleSuccessPanel, null, "GamePanels/BattlePanel/BattleSuccessPanel", true, 1);
            UIDataTable.AddPanelData(UIID.BattleFailedPanel, null, "GamePanels/BattlePanel/BattleFailedPanel", true, 1);
            UIDataTable.AddPanelData(UIID.ShipBuildingPanel, null, "GamePanels/ShipBuildingPanel/ShipBuildingPanel", true, 1);
            UIDataTable.AddPanelData(UIID.SelectArtifactPanel, null, "GamePanels/SelectArtifactPanel/SelectArtifactPanel", true, 1);
            UIDataTable.AddPanelData(UIID.JoystickPanel, null, "GamePanels/JoystickPanel/JoystickPanel", true, 1);
            UIDataTable.AddPanelData(UIID.SaveHeroInCagePanel, null, "GamePanels/SaveHeroInCagePanel/SaveHeroInCagePanel", true, 1);

            //CreditMgr.S.RegisterPanels();
        }
    }
}
