using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFrame;

namespace Game.Logic
{
    public class TableModule : AbstractTableModule
    {

        protected override void OnTableLoadFinish()
        {
            //TDConstTable.InitArrays(typeof(ConstType));

            //处理所有表的重建

            //Log.i("Load table finished");

            //CreditMgr.S.OnTableLoaded();
        }

        protected override void InitPreLoadTableMetaData()
        {
            TableConfig.preLoadTableArray = new TDTableMetaData[]
            {
                // Default table
                TDConstTable.metaData,
                TDLanguageTable.GetLanguageMetaData(),
                TDGuideTable.metaData,
                TDGuideStepTable.metaData,


                //TDArtifactConfigTable.metaData,
                //TDReformConfigTable.metaData,
                //TDShipLevelConfigTable.metaData,
                //TDHeroConfigTable.metaData,
                //TDWeaponConfigTable.metaData,
                //TDEnemyConfigTable.metaData,
                //TDResourceConfigTable.metaData,
                //TDLevelConfigTable.metaData,
                //TDShipConfigTable.metaData,
                //TDLevelWaveConfigTable.metaData,
                //TDItemConfigTable.metaData,
                //TDTotemConfigTable.metaData,
                //TDBuffConfigTable.metaData,
                //TDChapterConfigTable.metaData,
                //TDPlayerLevelConfigTable.metaData,
                //TDCaptainConfigTable.metaData,
                //TDFellowConfigTable.metaData,
                //TDShipWidgetConfigTable.metaData,
                //TDTurretConfigTable.metaData,
                //TDTalentConfigTable.metaData,
                //TDEnemySkillConfigTable.metaData,
            };

            //TableConfig.preLoadTableArray = CreditMgr.S.CombineMetaData(TableConfig.preLoadTableArray);
        }
    }
}
