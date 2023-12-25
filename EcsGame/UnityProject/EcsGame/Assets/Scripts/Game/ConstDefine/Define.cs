using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using GameFrame;

namespace Game.Logic
{
    public class Define
    {
        /// <summary>
        /// 常用物品id
        /// </summary>
        public const int ITEM_DIAMOND = 1000001; //绑钻钻石
        public const int ITEM_DIAMOND2 = 1000002; //付费钻石
        public const int ITEM_GOLD = 1000003;//金币
        public const int ITEM_POWER = 1000004; //体力
        public const int ITEM_PLAYER_EXP = 1000005; //玩家经验
        public const int ITEM_CAPTAIN_EXP = 1000006; //队长经验
        public const int ITEM_EXP_BOOK = 4000002; //经验书

        public const int DEFAULT_COIN_NUM = 0;
        public const int DEFAULT_DIAMOND_NUM = 0;

        public const int LEVEL_COUNT_PER_CHAPTER = 5;

        public const string SHIP_BOARD_ITEM = "ShipBoardItem";
        public const string SHIP1 = "Ship1";

        #region Layer
        //Sort Layers
        public static string GROUND_LAYER = "Ground";
        public static string PLAYER_LAYER = "Player";
        //Layers
        public static string ENEMY_LAYER = "Enemy";
        public static string HERO_LAYER = "Hero";
        public static string MAP_LAYER = "Map";
        //LayerMask
        public static LayerMask ENEMY_LAYER_MASK = 1 << LayerMask.NameToLayer(Define.ENEMY_LAYER);
        public static LayerMask HERO_LAYER_MASK = 1 << LayerMask.NameToLayer(Define.HERO_LAYER);
        public static LayerMask MAP_LAYER_MASK = 1 << LayerMask.NameToLayer(Define.MAP_LAYER);
        #endregion

        #region Tag

        //Tags
        public static string TAG_ENEMY = "Enemy";
        public static string TAG_HERO = "Hero";
        public static string TAG_NPC = "NPC";
        public static string TAG_PROJECTILE = "Projectile";
        public static string TAG_SHIP = "Ship";
        #endregion

        #region Asset

        //Hero
        public const string ASSET_HERO1 = "Hero1";
        //HeroProjectile
        public const string ASSET_HERO_PROJECTILE1 = "HeroProjectile1";
        //Turret
        public const string ASSET_TURRET = "Turret1";
        //Weapon
        public const string ASSET_WEAPON1 = "Weapon1";
        //Enemy
        public const string ASSET_ENEMY1 = "Enemy1";
        //Effect
        public const string ASSET_EFFECT_POP_TEXT = "Effect_Poptext";
        public const string ASSET_EFFECT_FIRE_DOT = "Effect_FireDot";
        public const string ASSET_EFFECT_ICE_DOT = "Effect_IceDot";
        public const string ASSET_EFFECT_RUSH_TIP = "Effect_RushTip";
        public const string ASSET_EFFECT_EXPLOSION = "Effect_Explosion";
        public const string ASSET_EFFECT_ENEMY_HURT = "Effect_EnemyHurt";
        #endregion
    }
}
