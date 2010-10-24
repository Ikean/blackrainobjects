﻿using System;

namespace BlackRain.Common
{
    /// <summary>
    /// A collection of offsets used for memory reading and writing.
    /// </summary>
    public class Offsets
    {
        /****
         * Missing XML Documentation warnings by ReSharper are being supressed in 
         * this file with the use of the #pragma statement below.
         */

        #pragma warning disable 1591

        /// <summary>
        /// Memory locations specific to the WowPlayer type.
        /// </summary>
        public enum WowPlayer: uint
        {
            NameStore = 0x00881988 + 0x8,
            NameMask = 0x24,
            NameBase = 0x1C, 
            NameString = 0x20 
        }

        /// <summary>
        /// Memory locations specific to the ObjectManager.
        /// </summary>
        public enum ObjectManager
        {
            Tls = 0x008A5C20,
            CurMgr = 0x4618,
            LocalGuid = 0xC8,
            FirstObject = 0xB4,
            NextObject = 0x3C,
        }

        /// <summary>
        /// Memory locations specific to the WowPlayerMe type.
        /// </summary>
        public enum WowPlayerMe: uint
        {
            Zone = 0x981688,
            SubZone = 0x981684
        }

        /// <summary>
        /// Memory locations specific to the WowObject type.
        /// </summary>
        public enum WowObject : uint
        {
            X = 0x880,
            Y = 0x884,
            Z = 0x888,
            GameObjectX = 0x110,
            GameObjectY = 0x114,
            GameObjectZ = 0x118,
            Facing = 0x894,
        }

        /// <summary>
        /// Memory locations specific to the WowGameObject type.
        /// </summary>
        public enum WowGameObject : uint
        {
            Name1 = 0x1CC,
            Name2 = 0x94,
        }

        #region <Flags>

        [Flags]
        public enum ClassFlags : uint
        {
            None = 0,
            Warrior = 1,
            Paladin = 2,
            Hunter = 3,
            Rogue = 4,
            Priest = 5,
            DeathKnight = 6,
            Shaman = 7,
            Mage = 8,
            Warlock = 9,
            Druid = 11,
        }

        [Flags]
        public enum RaceFlags : uint
        {
            Human = 1,
            Orc,
            Dwarf,
            NightElf,
            Undead,
            Tauren,
            Gnome,
            Troll,
            Goblin,
            BloodElf,
            Draenei,
            FelOrc,
            Naga,
            Broken,
            Skeleton = 15,
        }

        [Flags]
        public enum CorpseFlags
        {
            CORPSE_FLAG_NONE = 0x00,
            CORPSE_FLAG_BONES = 0x01,
            CORPSE_FLAG_UNK1 = 0x02,
            CORPSE_FLAG_UNK2 = 0x04,
            CORPSE_FLAG_HIDE_HELM = 0x08,
            CORPSE_FLAG_HIDE_CLOAK = 0x10,
            CORPSE_FLAG_LOOTABLE = 0x20
        }

        [Flags]
        public enum UnitDynamicFlags
        {
            None = 0,
            Lootable = 0x1,
            TrackUnit = 0x2,
            TaggedByOther = 0x4,
            TaggedByMe = 0x8,
            SpecialInfo = 0x10,
            Dead = 0x20,
            ReferAFriendLinked = 0x40,
            IsTappedByAllThreatList = 0x80,
        }

        [Flags]
        public enum UnitFlags : uint
        {
            None = 0,
            Sitting = 0x1,
            //SelectableNotAttackable_1 = 0x2,
            Influenced = 0x4, // Stops movement packets
            PlayerControlled = 0x8, // 2.4.2
            Totem = 0x10,
            Preparation = 0x20, // 3.0.3
            PlusMob = 0x40, // 3.0.2
            //SelectableNotAttackable_2 = 0x80,
            NotAttackable = 0x100,
            //Flag_0x200 = 0x200,
            Looting = 0x400,
            PetInCombat = 0x800, // 3.0.2
            PvPFlagged = 0x1000,
            Silenced = 0x2000, //3.0.3
            //Flag_14_0x4000 = 0x4000,
            //Flag_15_0x8000 = 0x8000,
            //SelectableNotAttackable_3 = 0x10000,
            Pacified = 0x20000, //3.0.3
            Stunned = 0x40000,
            CanPerformAction_Mask1 = 0x60000,
            Combat = 0x80000, // 3.1.1
            TaxiFlight = 0x100000, // 3.1.1
            Disarmed = 0x200000, // 3.1.1
            Confused = 0x400000, //  3.0.3
            Fleeing = 0x800000,
            Possessed = 0x1000000, // 3.1.1
            NotSelectable = 0x2000000,
            Skinnable = 0x4000000,
            Mounted = 0x8000000,
            //Flag_28_0x10000000 = 0x10000000,
            Dazed = 0x20000000,
            Sheathe = 0x40000000,
            //Flag_31_0x80000000 = 0x80000000,
        }

        #endregion

        #region <Descriptors>

        public enum WowObjectFields
        {
            OBJECT_FIELD_GUID = 0x0,
            OBJECT_FIELD_TYPE = 0x2,
            OBJECT_FIELD_ENTRY = 0x3,
            OBJECT_FIELD_SCALE_X = 0x4,
            OBJECT_FIELD_DATA = 0x5,
            OBJECT_FIELD_CREATED_BY = 0x6,
            OBJECT_FIELD_PADDING = 0x7,
        };

        public enum WowItemFields
        {
            ITEM_FIELD_OWNER = 0x8 + 0x0,
            ITEM_FIELD_CONTAINED = 0x8 + 0x2,
            ITEM_FIELD_CREATOR = 0x8 + 0x4,
            ITEM_FIELD_GIFTCREATOR = 0x8 + 0x6,
            ITEM_FIELD_STACK_COUNT = 0x8 + 0x8,
            ITEM_FIELD_DURATION = 0x8 + 0x9,
            ITEM_FIELD_SPELL_CHARGES = 0x8 + 0xA,
            ITEM_FIELD_FLAGS = 0x8 + 0xF,
            ITEM_FIELD_ENCHANTMENT_1_1 = 0x8 + 0x10,
            ITEM_FIELD_ENCHANTMENT_1_3 = 0x8 + 0x12,
            ITEM_FIELD_ENCHANTMENT_2_1 = 0x8 + 0x13,
            ITEM_FIELD_ENCHANTMENT_2_3 = 0x8 + 0x15,
            ITEM_FIELD_ENCHANTMENT_3_1 = 0x8 + 0x16,
            ITEM_FIELD_ENCHANTMENT_3_3 = 0x8 + 0x18,
            ITEM_FIELD_ENCHANTMENT_4_1 = 0x8 + 0x19,
            ITEM_FIELD_ENCHANTMENT_4_3 = 0x8 + 0x1B,
            ITEM_FIELD_ENCHANTMENT_5_1 = 0x8 + 0x1C,
            ITEM_FIELD_ENCHANTMENT_5_3 = 0x8 + 0x1E,
            ITEM_FIELD_ENCHANTMENT_6_1 = 0x8 + 0x1F,
            ITEM_FIELD_ENCHANTMENT_6_3 = 0x8 + 0x21,
            ITEM_FIELD_ENCHANTMENT_7_1 = 0x8 + 0x22,
            ITEM_FIELD_ENCHANTMENT_7_3 = 0x8 + 0x24,
            ITEM_FIELD_ENCHANTMENT_8_1 = 0x8 + 0x25,
            ITEM_FIELD_ENCHANTMENT_8_3 = 0x8 + 0x27,
            ITEM_FIELD_ENCHANTMENT_9_1 = 0x8 + 0x28,
            ITEM_FIELD_ENCHANTMENT_9_3 = 0x8 + 0x2A,
            ITEM_FIELD_ENCHANTMENT_10_1 = 0x8 + 0x2B,
            ITEM_FIELD_ENCHANTMENT_10_3 = 0x8 + 0x2D,
            ITEM_FIELD_ENCHANTMENT_11_1 = 0x8 + 0x2E,
            ITEM_FIELD_ENCHANTMENT_11_3 = 0x8 + 0x30,
            ITEM_FIELD_ENCHANTMENT_12_1 = 0x8 + 0x31,
            ITEM_FIELD_ENCHANTMENT_12_3 = 0x8 + 0x33,
            ITEM_FIELD_ENCHANTMENT_13_1 = 0x8 + 0x34,
            ITEM_FIELD_ENCHANTMENT_13_3 = 0x8 + 0x36,
            ITEM_FIELD_ENCHANTMENT_14_1 = 0x8 + 0x37,
            ITEM_FIELD_ENCHANTMENT_14_3 = 0x8 + 0x39,
            ITEM_FIELD_PROPERTY_SEED = 0x8 + 0x3A,
            ITEM_FIELD_RANDOM_PROPERTIES_ID = 0x8 + 0x3B,
            ITEM_FIELD_DURABILITY = 0x8 + 0x3C,
            ITEM_FIELD_MAXDURABILITY = 0x8 + 0x3D,
            ITEM_FIELD_CREATE_PLAYED_TIME = 0x8 + 0x3E,
            ITEM_FIELD_PAD = 0x8 + 0x3F,
            //TOTAL_ITEM_FIELDS = 0x26
        };

        public enum WowContainerFields
        {
            CONTAINER_FIELD_NUM_SLOTS = 0x48 + 0x0,
            CONTAINER_ALIGN_PAD = 0x48 + 0x1,
            CONTAINER_FIELD_SLOT_1 = 0x48 + 0x2,
            //TOTAL_CONTAINER_FIELDS = 0x3
        };

        public enum WowGameObjectFields
        {
            GAMEOBJECT_DISPLAYID = 0x8 + 0x2,
            GAMEOBJECT_FLAGS = 0x8 + 0x3,
            GAMEOBJECT_PARENTROTATION = 0x8 + 0x4,
            GAMEOBJECT_DYNAMIC = 0x8 + 0x8,
            GAMEOBJECT_FACTION = 0x8 + 0x9,
            GAMEOBJECT_LEVEL = 0x8 + 0xA,
            GAMEOBJECT_BYTES_1 = 0x8 + 0xB,
        };

        public enum WowDynamicObjectFields
        {
            DYNAMICOBJECT_CASTER = 0x6,
            DYNAMICOBJECT_BYTES = 0x8,
            DYNAMICOBJECT_SPELLID = 0x9,
            DYNAMICOBJECT_RADIUS = 0xA,
            DYNAMICOBJECT_CASTTIME = 0xB,
        }

        public enum WowCorpseFields
        {
            CORPSE_FIELD_OWNER = 0x6,
            CORPSE_FIELD_PARTY = 0x8,
            CORPSE_FIELD_DISPLAY_ID = 0xA,
            CORPSE_FIELD_ITEM = 0xB,
            CORPSE_FIELD_BYTES_1 = 0x1E,
            CORPSE_FIELD_BYTES_2 = 0x1F,
            CORPSE_FIELD_GUILD = 0x20,
            CORPSE_FIELD_FLAGS = 0x21,
            CORPSE_FIELD_DYNAMIC_FLAGS = 0x22,
            CORPSE_FIELD_PAD = 0x23,
        }

        public enum WowUnitFields
        {
            UNIT_FIELD_CHARM = 0x8 + 0x0,
            UNIT_FIELD_SUMMON = 0x8 + 0x2,
            UNIT_FIELD_CRITTER = 0x8 + 0x4,
            UNIT_FIELD_CHARMEDBY = 0x8 + 0x6,
            UNIT_FIELD_SUMMONEDBY = 0x8 + 0x8,
            UNIT_FIELD_CREATEDBY = 0x8 + 0xA,
            UNIT_FIELD_TARGET = 0x8 + 0xC,
            UNIT_FIELD_CHANNEL_OBJECT = 0x8 + 0xE,
            UNIT_CHANNEL_SPELL = 0x8 + 0x10,
            UNIT_FIELD_BYTES_0 = 0x8 + 0x11,
            UNIT_FIELD_HEALTH = 0x8 + 0x12,
            UNIT_FIELD_POWER1 = 0x8 + 0x13,
            UNIT_FIELD_POWER2 = 0x8 + 0x14,
            UNIT_FIELD_POWER3 = 0x8 + 0x15,
            UNIT_FIELD_POWER4 = 0x8 + 0x16,
            UNIT_FIELD_POWER5 = 0x8 + 0x17,
            UNIT_FIELD_POWER6 = 0x8 + 0x18,
            UNIT_FIELD_POWER7 = 0x8 + 0x19,
            UNIT_FIELD_POWER8 = 0x8 + 0x1A,
            UNIT_FIELD_POWER9 = 0x8 + 0x1B,
            UNIT_FIELD_POWER10 = 0x8 + 0x1C,
            UNIT_FIELD_POWER11 = 0x8 + 0x1D,
            UNIT_FIELD_MAXHEALTH = 0x8 + 0x1E,
            UNIT_FIELD_MAXPOWER1 = 0x8 + 0x1F,
            UNIT_FIELD_MAXPOWER2 = 0x8 + 0x20,
            UNIT_FIELD_MAXPOWER3 = 0x8 + 0x21,
            UNIT_FIELD_MAXPOWER4 = 0x8 + 0x22,
            UNIT_FIELD_MAXPOWER5 = 0x8 + 0x23,
            UNIT_FIELD_MAXPOWER6 = 0x8 + 0x24,
            UNIT_FIELD_MAXPOWER7 = 0x8 + 0x25,
            UNIT_FIELD_MAXPOWER8 = 0x8 + 0x26,
            UNIT_FIELD_MAXPOWER9 = 0x8 + 0x27,
            UNIT_FIELD_MAXPOWER10 = 0x8 + 0x28,
            UNIT_FIELD_MAXPOWER11 = 0x8 + 0x29,
            UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER = 0x8 + 0x2A,
            UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER = 0x8 + 0x35,
            UNIT_FIELD_LEVEL = 0x8 + 0x40,
            UNIT_FIELD_FACTIONTEMPLATE = 0x8 + 0x41,
            UNIT_VIRTUAL_ITEM_SLOT_ID = 0x8 + 0x42,
            UNIT_FIELD_FLAGS = 0x8 + 0x45,
            UNIT_FIELD_FLAGS_2 = 0x8 + 0x46,
            UNIT_FIELD_AURASTATE = 0x8 + 0x47,
            UNIT_FIELD_BASEATTACKTIME = 0x8 + 0x48,
            UNIT_FIELD_RANGEDATTACKTIME = 0x8 + 0x4A,
            UNIT_FIELD_BOUNDINGRADIUS = 0x8 + 0x4B,
            UNIT_FIELD_COMBATREACH = 0x8 + 0x4C,
            UNIT_FIELD_DISPLAYID = 0x8 + 0x4D,
            UNIT_FIELD_NATIVEDISPLAYID = 0x8 + 0x4E,
            UNIT_FIELD_MOUNTDISPLAYID = 0x8 + 0x4F,
            UNIT_FIELD_MINDAMAGE = 0x8 + 0x50,
            UNIT_FIELD_MAXDAMAGE = 0x8 + 0x51,
            UNIT_FIELD_MINOFFHANDDAMAGE = 0x8 + 0x52,
            UNIT_FIELD_MAXOFFHANDDAMAGE = 0x8 + 0x53,
            UNIT_FIELD_BYTES_1 = 0x8 + 0x54,
            UNIT_FIELD_PETNUMBER = 0x8 + 0x55,
            UNIT_FIELD_PET_NAME_TIMESTAMP = 0x8 + 0x56,
            UNIT_FIELD_PETEXPERIENCE = 0x8 + 0x57,
            UNIT_FIELD_PETNEXTLEVELEXP = 0x8 + 0x58,
            UNIT_DYNAMIC_FLAGS = 0x8 + 0x59,
            UNIT_MOD_CAST_SPEED = 0x8 + 0x5A,
            UNIT_CREATED_BY_SPELL = 0x8 + 0x5B,
            UNIT_NPC_FLAGS = 0x8 + 0x5C,
            UNIT_NPC_EMOTESTATE = 0x8 + 0x5D,
            UNIT_FIELD_STAT0 = 0x8 + 0x5E,
            UNIT_FIELD_STAT1 = 0x8 + 0x5F,
            UNIT_FIELD_STAT2 = 0x8 + 0x60,
            UNIT_FIELD_STAT3 = 0x8 + 0x61,
            UNIT_FIELD_STAT4 = 0x8 + 0x62,
            UNIT_FIELD_POSSTAT0 = 0x8 + 0x63,
            UNIT_FIELD_POSSTAT1 = 0x8 + 0x64,
            UNIT_FIELD_POSSTAT2 = 0x8 + 0x65,
            UNIT_FIELD_POSSTAT3 = 0x8 + 0x66,
            UNIT_FIELD_POSSTAT4 = 0x8 + 0x67,
            UNIT_FIELD_NEGSTAT0 = 0x8 + 0x68,
            UNIT_FIELD_NEGSTAT1 = 0x8 + 0x69,
            UNIT_FIELD_NEGSTAT2 = 0x8 + 0x6A,
            UNIT_FIELD_NEGSTAT3 = 0x8 + 0x6B,
            UNIT_FIELD_NEGSTAT4 = 0x8 + 0x6C,
            UNIT_FIELD_RESISTANCES = 0x8 + 0x6D,
            UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE = 0x8 + 0x74,
            UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE = 0x8 + 0x7B,
            UNIT_FIELD_BASE_MANA = 0x8 + 0x82,
            UNIT_FIELD_BASE_HEALTH = 0x8 + 0x83,
            UNIT_FIELD_BYTES_2 = 0x8 + 0x84,
            UNIT_FIELD_ATTACK_POWER = 0x8 + 0x85,
            UNIT_FIELD_ATTACK_POWER_MODS = 0x8 + 0x86,
            UNIT_FIELD_ATTACK_POWER_MULTIPLIER = 0x8 + 0x87,
            UNIT_FIELD_RANGED_ATTACK_POWER = 0x8 + 0x88,
            UNIT_FIELD_RANGED_ATTACK_POWER_MODS = 0x8 + 0x89,
            UNIT_FIELD_RANGED_ATTACK_POWER_MULTIPLIER = 0x8 + 0x8A,
            UNIT_FIELD_MINRANGEDDAMAGE = 0x8 + 0x8B,
            UNIT_FIELD_MAXRANGEDDAMAGE = 0x8 + 0x8C,
            UNIT_FIELD_POWER_COST_MODIFIER = 0x8 + 0x8D,
            UNIT_FIELD_POWER_COST_MULTIPLIER = 0x8 + 0x94,
            UNIT_FIELD_MAXHEALTHMODIFIER = 0x8 + 0x9B,
            UNIT_FIELD_HOVERHEIGHT = 0x8 + 0x9C,
            UNIT_FIELD_MAXITEMLEVEL = 0x8 + 0x9D,
        };

        public enum WowPlayerFields
        {
            PLAYER_DUEL_ARBITER = 0xA6 + 0x0,
            PLAYER_FLAGS = 0xA6 + 0x2,
            PLAYER_GUILDRANK = 0xA6 + 0x3,
            PLAYER_GUILDDELETE_DATE = 0xA6 + 0x4,
            PLAYER_GUILDLEVEL = 0xA6 + 0x5,
            PLAYER_BYTES = 0xA6 + 0x6,
            PLAYER_BYTES_2 = 0xA6 + 0x7,
            PLAYER_BYTES_3 = 0xA6 + 0x8,
            PLAYER_DUEL_TEAM = 0xA6 + 0x9,
            PLAYER_GUILD_TIMESTAMP = 0xA6 + 0xA,
            PLAYER_QUEST_LOG_1_1 = 0xA6 + 0xB,
            PLAYER_QUEST_LOG_1_2 = 0xA6 + 0xC,
            PLAYER_QUEST_LOG_1_3 = 0xA6 + 0xD,
            PLAYER_QUEST_LOG_1_4 = 0xA6 + 0xF,
            PLAYER_QUEST_LOG_2_1 = 0xA6 + 0x10,
            PLAYER_QUEST_LOG_2_2 = 0xA6 + 0x11,
            PLAYER_QUEST_LOG_2_3 = 0xA6 + 0x12,
            PLAYER_QUEST_LOG_2_5 = 0xA6 + 0x14,
            PLAYER_QUEST_LOG_3_1 = 0xA6 + 0x15,
            PLAYER_QUEST_LOG_3_2 = 0xA6 + 0x16,
            PLAYER_QUEST_LOG_3_3 = 0xA6 + 0x17,
            PLAYER_QUEST_LOG_3_5 = 0xA6 + 0x19,
            PLAYER_QUEST_LOG_4_1 = 0xA6 + 0x1A,
            PLAYER_QUEST_LOG_4_2 = 0xA6 + 0x1B,
            PLAYER_QUEST_LOG_4_3 = 0xA6 + 0x1C,
            PLAYER_QUEST_LOG_4_5 = 0xA6 + 0x1E,
            PLAYER_QUEST_LOG_5_1 = 0xA6 + 0x1F,
            PLAYER_QUEST_LOG_5_2 = 0xA6 + 0x20,
            PLAYER_QUEST_LOG_5_3 = 0xA6 + 0x21,
            PLAYER_QUEST_LOG_5_5 = 0xA6 + 0x23,
            PLAYER_QUEST_LOG_6_1 = 0xA6 + 0x24,
            PLAYER_QUEST_LOG_6_2 = 0xA6 + 0x25,
            PLAYER_QUEST_LOG_6_3 = 0xA6 + 0x26,
            PLAYER_QUEST_LOG_6_5 = 0xA6 + 0x28,
            PLAYER_QUEST_LOG_7_1 = 0xA6 + 0x29,
            PLAYER_QUEST_LOG_7_2 = 0xA6 + 0x2A,
            PLAYER_QUEST_LOG_7_3 = 0xA6 + 0x2B,
            PLAYER_QUEST_LOG_7_5 = 0xA6 + 0x2D,
            PLAYER_QUEST_LOG_8_1 = 0xA6 + 0x2E,
            PLAYER_QUEST_LOG_8_2 = 0xA6 + 0x2F,
            PLAYER_QUEST_LOG_8_3 = 0xA6 + 0x30,
            PLAYER_QUEST_LOG_8_5 = 0xA6 + 0x32,
            PLAYER_QUEST_LOG_9_1 = 0xA6 + 0x33,
            PLAYER_QUEST_LOG_9_2 = 0xA6 + 0x34,
            PLAYER_QUEST_LOG_9_3 = 0xA6 + 0x35,
            PLAYER_QUEST_LOG_9_5 = 0xA6 + 0x37,
            PLAYER_QUEST_LOG_10_1 = 0xA6 + 0x38,
            PLAYER_QUEST_LOG_10_2 = 0xA6 + 0x39,
            PLAYER_QUEST_LOG_10_3 = 0xA6 + 0x3A,
            PLAYER_QUEST_LOG_10_5 = 0xA6 + 0x3C,
            PLAYER_QUEST_LOG_11_1 = 0xA6 + 0x3D,
            PLAYER_QUEST_LOG_11_2 = 0xA6 + 0x3E,
            PLAYER_QUEST_LOG_11_3 = 0xA6 + 0x3F,
            PLAYER_QUEST_LOG_11_5 = 0xA6 + 0x41,
            PLAYER_QUEST_LOG_12_1 = 0xA6 + 0x42,
            PLAYER_QUEST_LOG_12_2 = 0xA6 + 0x43,
            PLAYER_QUEST_LOG_12_3 = 0xA6 + 0x44,
            PLAYER_QUEST_LOG_12_5 = 0xA6 + 0x46,
            PLAYER_QUEST_LOG_13_1 = 0xA6 + 0x47,
            PLAYER_QUEST_LOG_13_2 = 0xA6 + 0x48,
            PLAYER_QUEST_LOG_13_3 = 0xA6 + 0x49,
            PLAYER_QUEST_LOG_13_5 = 0xA6 + 0x4B,
            PLAYER_QUEST_LOG_14_1 = 0xA6 + 0x4C,
            PLAYER_QUEST_LOG_14_2 = 0xA6 + 0x4D,
            PLAYER_QUEST_LOG_14_3 = 0xA6 + 0x4E,
            PLAYER_QUEST_LOG_14_5 = 0xA6 + 0x50,
            PLAYER_QUEST_LOG_15_1 = 0xA6 + 0x51,
            PLAYER_QUEST_LOG_15_2 = 0xA6 + 0x52,
            PLAYER_QUEST_LOG_15_3 = 0xA6 + 0x53,
            PLAYER_QUEST_LOG_15_5 = 0xA6 + 0x55,
            PLAYER_QUEST_LOG_16_1 = 0xA6 + 0x56,
            PLAYER_QUEST_LOG_16_2 = 0xA6 + 0x57,
            PLAYER_QUEST_LOG_16_3 = 0xA6 + 0x58,
            PLAYER_QUEST_LOG_16_5 = 0xA6 + 0x5A,
            PLAYER_QUEST_LOG_17_1 = 0xA6 + 0x5B,
            PLAYER_QUEST_LOG_17_2 = 0xA6 + 0x5C,
            PLAYER_QUEST_LOG_17_3 = 0xA6 + 0x5D,
            PLAYER_QUEST_LOG_17_5 = 0xA6 + 0x5F,
            PLAYER_QUEST_LOG_18_1 = 0xA6 + 0x60,
            PLAYER_QUEST_LOG_18_2 = 0xA6 + 0x61,
            PLAYER_QUEST_LOG_18_3 = 0xA6 + 0x62,
            PLAYER_QUEST_LOG_18_5 = 0xA6 + 0x64,
            PLAYER_QUEST_LOG_19_1 = 0xA6 + 0x65,
            PLAYER_QUEST_LOG_19_2 = 0xA6 + 0x66,
            PLAYER_QUEST_LOG_19_3 = 0xA6 + 0x67,
            PLAYER_QUEST_LOG_19_5 = 0xA6 + 0x69,
            PLAYER_QUEST_LOG_20_1 = 0xA6 + 0x6A,
            PLAYER_QUEST_LOG_20_2 = 0xA6 + 0x6B,
            PLAYER_QUEST_LOG_20_3 = 0xA6 + 0x6C,
            PLAYER_QUEST_LOG_20_5 = 0xA6 + 0x6E,
            PLAYER_QUEST_LOG_21_1 = 0xA6 + 0x6F,
            PLAYER_QUEST_LOG_21_2 = 0xA6 + 0x70,
            PLAYER_QUEST_LOG_21_3 = 0xA6 + 0x71,
            PLAYER_QUEST_LOG_21_5 = 0xA6 + 0x73,
            PLAYER_QUEST_LOG_22_1 = 0xA6 + 0x74,
            PLAYER_QUEST_LOG_22_2 = 0xA6 + 0x75,
            PLAYER_QUEST_LOG_22_3 = 0xA6 + 0x76,
            PLAYER_QUEST_LOG_22_5 = 0xA6 + 0x78,
            PLAYER_QUEST_LOG_23_1 = 0xA6 + 0x79,
            PLAYER_QUEST_LOG_23_2 = 0xA6 + 0x7A,
            PLAYER_QUEST_LOG_23_3 = 0xA6 + 0x7B,
            PLAYER_QUEST_LOG_23_5 = 0xA6 + 0x7D,
            PLAYER_QUEST_LOG_24_1 = 0xA6 + 0x7E,
            PLAYER_QUEST_LOG_24_2 = 0xA6 + 0x7F,
            PLAYER_QUEST_LOG_24_3 = 0xA6 + 0x80,
            PLAYER_QUEST_LOG_24_5 = 0xA6 + 0x82,
            PLAYER_QUEST_LOG_25_1 = 0xA6 + 0x83,
            PLAYER_QUEST_LOG_25_2 = 0xA6 + 0x84,
            PLAYER_QUEST_LOG_25_3 = 0xA6 + 0x85,
            PLAYER_QUEST_LOG_25_5 = 0xA6 + 0x87,
            PLAYER_QUEST_LOG_26_1 = 0xA6 + 0x88,
            PLAYER_QUEST_LOG_26_2 = 0xA6 + 0x89,
            PLAYER_QUEST_LOG_26_3 = 0xA6 + 0x8A,
            PLAYER_QUEST_LOG_26_5 = 0xA6 + 0x8C,
            PLAYER_QUEST_LOG_27_1 = 0xA6 + 0x8D,
            PLAYER_QUEST_LOG_27_2 = 0xA6 + 0x8E,
            PLAYER_QUEST_LOG_27_3 = 0xA6 + 0x8F,
            PLAYER_QUEST_LOG_27_5 = 0xA6 + 0x91,
            PLAYER_QUEST_LOG_28_1 = 0xA6 + 0x92,
            PLAYER_QUEST_LOG_28_2 = 0xA6 + 0x93,
            PLAYER_QUEST_LOG_28_3 = 0xA6 + 0x94,
            PLAYER_QUEST_LOG_28_5 = 0xA6 + 0x96,
            PLAYER_QUEST_LOG_29_1 = 0xA6 + 0x97,
            PLAYER_QUEST_LOG_29_2 = 0xA6 + 0x98,
            PLAYER_QUEST_LOG_29_3 = 0xA6 + 0x99,
            PLAYER_QUEST_LOG_29_5 = 0xA6 + 0x9B,
            PLAYER_QUEST_LOG_30_1 = 0xA6 + 0x9C,
            PLAYER_QUEST_LOG_30_2 = 0xA6 + 0x9D,
            PLAYER_QUEST_LOG_30_3 = 0xA6 + 0x9E,
            PLAYER_QUEST_LOG_30_5 = 0xA6 + 0xA0,
            PLAYER_QUEST_LOG_31_1 = 0xA6 + 0xA1,
            PLAYER_QUEST_LOG_31_2 = 0xA6 + 0xA2,
            PLAYER_QUEST_LOG_31_3 = 0xA6 + 0xA3,
            PLAYER_QUEST_LOG_31_5 = 0xA6 + 0xA5,
            PLAYER_QUEST_LOG_32_1 = 0xA6 + 0xA6,
            PLAYER_QUEST_LOG_32_2 = 0xA6 + 0xA7,
            PLAYER_QUEST_LOG_32_3 = 0xA6 + 0xA8,
            PLAYER_QUEST_LOG_32_5 = 0xA6 + 0xAA,
            PLAYER_QUEST_LOG_33_1 = 0xA6 + 0xAB,
            PLAYER_QUEST_LOG_33_2 = 0xA6 + 0xAC,
            PLAYER_QUEST_LOG_33_3 = 0xA6 + 0xAD,
            PLAYER_QUEST_LOG_33_5 = 0xA6 + 0xAF,
            PLAYER_QUEST_LOG_34_1 = 0xA6 + 0xB0,
            PLAYER_QUEST_LOG_34_2 = 0xA6 + 0xB1,
            PLAYER_QUEST_LOG_34_3 = 0xA6 + 0xB2,
            PLAYER_QUEST_LOG_34_5 = 0xA6 + 0xB4,
            PLAYER_QUEST_LOG_35_1 = 0xA6 + 0xB5,
            PLAYER_QUEST_LOG_35_2 = 0xA6 + 0xB6,
            PLAYER_QUEST_LOG_35_3 = 0xA6 + 0xB7,
            PLAYER_QUEST_LOG_35_5 = 0xA6 + 0xB9,
            PLAYER_QUEST_LOG_36_1 = 0xA6 + 0xBA,
            PLAYER_QUEST_LOG_36_2 = 0xA6 + 0xBB,
            PLAYER_QUEST_LOG_36_3 = 0xA6 + 0xBC,
            PLAYER_QUEST_LOG_36_5 = 0xA6 + 0xBE,
            PLAYER_QUEST_LOG_37_1 = 0xA6 + 0xBF,
            PLAYER_QUEST_LOG_37_2 = 0xA6 + 0xC0,
            PLAYER_QUEST_LOG_37_3 = 0xA6 + 0xC1,
            PLAYER_QUEST_LOG_37_5 = 0xA6 + 0xC3,
            PLAYER_QUEST_LOG_38_1 = 0xA6 + 0xC4,
            PLAYER_QUEST_LOG_38_2 = 0xA6 + 0xC5,
            PLAYER_QUEST_LOG_38_3 = 0xA6 + 0xC6,
            PLAYER_QUEST_LOG_38_5 = 0xA6 + 0xC8,
            PLAYER_QUEST_LOG_39_1 = 0xA6 + 0xC9,
            PLAYER_QUEST_LOG_39_2 = 0xA6 + 0xCA,
            PLAYER_QUEST_LOG_39_3 = 0xA6 + 0xCB,
            PLAYER_QUEST_LOG_39_5 = 0xA6 + 0xCD,
            PLAYER_QUEST_LOG_40_1 = 0xA6 + 0xCE,
            PLAYER_QUEST_LOG_40_2 = 0xA6 + 0xCF,
            PLAYER_QUEST_LOG_40_3 = 0xA6 + 0xD0,
            PLAYER_QUEST_LOG_40_5 = 0xA6 + 0xD2,
            PLAYER_QUEST_LOG_41_1 = 0xA6 + 0xD3,
            PLAYER_QUEST_LOG_41_2 = 0xA6 + 0xD4,
            PLAYER_QUEST_LOG_41_3 = 0xA6 + 0xD5,
            PLAYER_QUEST_LOG_41_5 = 0xA6 + 0xD7,
            PLAYER_QUEST_LOG_42_1 = 0xA6 + 0xD8,
            PLAYER_QUEST_LOG_42_2 = 0xA6 + 0xD9,
            PLAYER_QUEST_LOG_42_3 = 0xA6 + 0xDA,
            PLAYER_QUEST_LOG_42_5 = 0xA6 + 0xDC,
            PLAYER_QUEST_LOG_43_1 = 0xA6 + 0xDD,
            PLAYER_QUEST_LOG_43_2 = 0xA6 + 0xDE,
            PLAYER_QUEST_LOG_43_3 = 0xA6 + 0xDF,
            PLAYER_QUEST_LOG_43_5 = 0xA6 + 0xE1,
            PLAYER_QUEST_LOG_44_1 = 0xA6 + 0xE2,
            PLAYER_QUEST_LOG_44_2 = 0xA6 + 0xE3,
            PLAYER_QUEST_LOG_44_3 = 0xA6 + 0xE4,
            PLAYER_QUEST_LOG_44_5 = 0xA6 + 0xE6,
            PLAYER_QUEST_LOG_45_1 = 0xA6 + 0xE7,
            PLAYER_QUEST_LOG_45_2 = 0xA6 + 0xE8,
            PLAYER_QUEST_LOG_45_3 = 0xA6 + 0xE9,
            PLAYER_QUEST_LOG_45_5 = 0xA6 + 0xEB,
            PLAYER_QUEST_LOG_46_1 = 0xA6 + 0xEC,
            PLAYER_QUEST_LOG_46_2 = 0xA6 + 0xED,
            PLAYER_QUEST_LOG_46_3 = 0xA6 + 0xEE,
            PLAYER_QUEST_LOG_46_5 = 0xA6 + 0xF0,
            PLAYER_QUEST_LOG_47_1 = 0xA6 + 0xF1,
            PLAYER_QUEST_LOG_47_2 = 0xA6 + 0xF2,
            PLAYER_QUEST_LOG_47_3 = 0xA6 + 0xF3,
            PLAYER_QUEST_LOG_47_5 = 0xA6 + 0xF5,
            PLAYER_QUEST_LOG_48_1 = 0xA6 + 0xF6,
            PLAYER_QUEST_LOG_48_2 = 0xA6 + 0xF7,
            PLAYER_QUEST_LOG_48_3 = 0xA6 + 0xF8,
            PLAYER_QUEST_LOG_48_5 = 0xA6 + 0xFA,
            PLAYER_QUEST_LOG_49_1 = 0xA6 + 0xFB,
            PLAYER_QUEST_LOG_49_2 = 0xA6 + 0xFC,
            PLAYER_QUEST_LOG_49_3 = 0xA6 + 0xFD,
            PLAYER_QUEST_LOG_49_5 = 0xA6 + 0xFF,
            PLAYER_QUEST_LOG_50_1 = 0xA6 + 0x100,
            PLAYER_QUEST_LOG_50_2 = 0xA6 + 0x101,
            PLAYER_QUEST_LOG_50_3 = 0xA6 + 0x102,
            PLAYER_QUEST_LOG_50_5 = 0xA6 + 0x104,
            PLAYER_VISIBLE_ITEM_1_ENTRYID = 0xA6 + 0x105,
            PLAYER_VISIBLE_ITEM_1_ENCHANTMENT = 0xA6 + 0x106,
            PLAYER_VISIBLE_ITEM_2_ENTRYID = 0xA6 + 0x107,
            PLAYER_VISIBLE_ITEM_2_ENCHANTMENT = 0xA6 + 0x108,
            PLAYER_VISIBLE_ITEM_3_ENTRYID = 0xA6 + 0x109,
            PLAYER_VISIBLE_ITEM_3_ENCHANTMENT = 0xA6 + 0x10A,
            PLAYER_VISIBLE_ITEM_4_ENTRYID = 0xA6 + 0x10B,
            PLAYER_VISIBLE_ITEM_4_ENCHANTMENT = 0xA6 + 0x10C,
            PLAYER_VISIBLE_ITEM_5_ENTRYID = 0xA6 + 0x10D,
            PLAYER_VISIBLE_ITEM_5_ENCHANTMENT = 0xA6 + 0x10E,
            PLAYER_VISIBLE_ITEM_6_ENTRYID = 0xA6 + 0x10F,
            PLAYER_VISIBLE_ITEM_6_ENCHANTMENT = 0xA6 + 0x110,
            PLAYER_VISIBLE_ITEM_7_ENTRYID = 0xA6 + 0x111,
            PLAYER_VISIBLE_ITEM_7_ENCHANTMENT = 0xA6 + 0x112,
            PLAYER_VISIBLE_ITEM_8_ENTRYID = 0xA6 + 0x113,
            PLAYER_VISIBLE_ITEM_8_ENCHANTMENT = 0xA6 + 0x114,
            PLAYER_VISIBLE_ITEM_9_ENTRYID = 0xA6 + 0x115,
            PLAYER_VISIBLE_ITEM_9_ENCHANTMENT = 0xA6 + 0x116,
            PLAYER_VISIBLE_ITEM_10_ENTRYID = 0xA6 + 0x117,
            PLAYER_VISIBLE_ITEM_10_ENCHANTMENT = 0xA6 + 0x118,
            PLAYER_VISIBLE_ITEM_11_ENTRYID = 0xA6 + 0x119,
            PLAYER_VISIBLE_ITEM_11_ENCHANTMENT = 0xA6 + 0x11A,
            PLAYER_VISIBLE_ITEM_12_ENTRYID = 0xA6 + 0x11B,
            PLAYER_VISIBLE_ITEM_12_ENCHANTMENT = 0xA6 + 0x11C,
            PLAYER_VISIBLE_ITEM_13_ENTRYID = 0xA6 + 0x11D,
            PLAYER_VISIBLE_ITEM_13_ENCHANTMENT = 0xA6 + 0x11E,
            PLAYER_VISIBLE_ITEM_14_ENTRYID = 0xA6 + 0x11F,
            PLAYER_VISIBLE_ITEM_14_ENCHANTMENT = 0xA6 + 0x120,
            PLAYER_VISIBLE_ITEM_15_ENTRYID = 0xA6 + 0x121,
            PLAYER_VISIBLE_ITEM_15_ENCHANTMENT = 0xA6 + 0x122,
            PLAYER_VISIBLE_ITEM_16_ENTRYID = 0xA6 + 0x123,
            PLAYER_VISIBLE_ITEM_16_ENCHANTMENT = 0xA6 + 0x124,
            PLAYER_VISIBLE_ITEM_17_ENTRYID = 0xA6 + 0x125,
            PLAYER_VISIBLE_ITEM_17_ENCHANTMENT = 0xA6 + 0x126,
            PLAYER_VISIBLE_ITEM_18_ENTRYID = 0xA6 + 0x127,
            PLAYER_VISIBLE_ITEM_18_ENCHANTMENT = 0xA6 + 0x128,
            PLAYER_VISIBLE_ITEM_19_ENTRYID = 0xA6 + 0x129,
            PLAYER_VISIBLE_ITEM_19_ENCHANTMENT = 0xA6 + 0x12A,
            PLAYER_CHOSEN_TITLE = 0xA6 + 0x12B,
            PLAYER_FAKE_INEBRIATION = 0xA6 + 0x12C,
            PLAYER_FIELD_PAD_0 = 0xA6 + 0x12D,
            PLAYER_FIELD_INV_SLOT_HEAD = 0xA6 + 0x12E,
            PLAYER_FIELD_PACK_SLOT_1 = 0xA6 + 0x15C,
            PLAYER_FIELD_BANK_SLOT_1 = 0xA6 + 0x17C,
            PLAYER_FIELD_BANKBAG_SLOT_1 = 0xA6 + 0x1B4,
            PLAYER_FIELD_VENDORBUYBACK_SLOT_1 = 0xA6 + 0x1C2,
            PLAYER_FIELD_KEYRING_SLOT_1 = 0xA6 + 0x1DA,
            PLAYER_FARSIGHT = 0xA6 + 0x21A,
            PLAYER__FIELD_KNOWN_TITLES = 0xA6 + 0x21C,
            PLAYER__FIELD_KNOWN_TITLES1 = 0xA6 + 0x21E,
            PLAYER__FIELD_KNOWN_TITLES2 = 0xA6 + 0x220,
            PLAYER_XP = 0xA6 + 0x222,
            PLAYER_NEXT_LEVEL_XP = 0xA6 + 0x223,
            PLAYER_SKILL_INFO_1_1 = 0xA6 + 0x224,
            PLAYER_CHARACTER_POINTS = 0xA6 + 0x3A4,
            PLAYER_TRACK_CREATURES = 0xA6 + 0x3A5,
            PLAYER_TRACK_RESOURCES = 0xA6 + 0x3A6,
            PLAYER_BLOCK_PERCENTAGE = 0xA6 + 0x3A7,
            PLAYER_DODGE_PERCENTAGE = 0xA6 + 0x3A8,
            PLAYER_PARRY_PERCENTAGE = 0xA6 + 0x3A9,
            PLAYER_EXPERTISE = 0xA6 + 0x3AA,
            PLAYER_OFFHAND_EXPERTISE = 0xA6 + 0x3AB,
            PLAYER_CRIT_PERCENTAGE = 0xA6 + 0x3AC,
            PLAYER_RANGED_CRIT_PERCENTAGE = 0xA6 + 0x3AD,
            PLAYER_OFFHAND_CRIT_PERCENTAGE = 0xA6 + 0x3AE,
            PLAYER_SPELL_CRIT_PERCENTAGE1 = 0xA6 + 0x3AF,
            PLAYER_SHIELD_BLOCK = 0xA6 + 0x3B6,
            PLAYER_SHIELD_BLOCK_CRIT_PERCENTAGE = 0xA6 + 0x3B7,
            PLAYER_MASTERY = 0xA6 + 0x3B8,
            PLAYER_EXPLORED_ZONES_1 = 0xA6 + 0x3B9,
            PLAYER_REST_STATE_EXPERIENCE = 0xA6 + 0x449,
            PLAYER_FIELD_COINAGE = 0xA6 + 0x44A,
            PLAYER_FIELD_MOD_DAMAGE_DONE_POS = 0xA6 + 0x44C,
            PLAYER_FIELD_MOD_DAMAGE_DONE_NEG = 0xA6 + 0x453,
            PLAYER_FIELD_MOD_DAMAGE_DONE_PCT = 0xA6 + 0x45A,
            PLAYER_FIELD_MOD_HEALING_DONE_POS = 0xA6 + 0x461,
            PLAYER_FIELD_MOD_HEALING_PCT = 0xA6 + 0x462,
            PLAYER_FIELD_MOD_HEALING_DONE_PCT = 0xA6 + 0x463,
            PLAYER_FIELD_MOD_SPELL_POWER_PCT = 0xA6 + 0x464,
            PLAYER_FIELD_MOD_TARGET_RESISTANCE = 0xA6 + 0x465,
            PLAYER_FIELD_MOD_TARGET_PHYSICAL_RESISTANCE = 0xA6 + 0x466,
            PLAYER_FIELD_BYTES = 0xA6 + 0x467,
            PLAYER_SELF_RES_SPELL = 0xA6 + 0x468,
            PLAYER_FIELD_PVP_MEDALS = 0xA6 + 0x469,
            PLAYER_FIELD_BUYBACK_PRICE_1 = 0xA6 + 0x46A,
            PLAYER_FIELD_BUYBACK_TIMESTAMP_1 = 0xA6 + 0x476,
            PLAYER_FIELD_KILLS = 0xA6 + 0x482,
            PLAYER_FIELD_LIFETIME_HONORBALE_KILLS = 0xA6 + 0x483,
            PLAYER_FIELD_BYTES2 = 0xA6 + 0x484,
            PLAYER_FIELD_WATCHED_FACTION_INDEX = 0xA6 + 0x485,
            PLAYER_FIELD_COMBAT_RATING_1 = 0xA6 + 0x486,
            PLAYER_FIELD_ARENA_TEAM_INFO_1_1 = 0xA6 + 0x4A0,
            PLAYER_FIELD_BATTLEGROUND_RATING = 0xA6 + 0x4B5,
            PLAYER_FIELD_MAX_LEVEL = 0xA6 + 0x4B6,
            PLAYER_FIELD_DAILY_QUESTS_1 = 0xA6 + 0x4B7,
            PLAYER_RUNE_REGEN_1 = 0xA6 + 0x4D0,
            PLAYER_NO_REAGENT_COST_1 = 0xA6 + 0x4D4,
            PLAYER_FIELD_GLYPH_SLOTS_1 = 0xA6 + 0x4D7,
            PLAYER_FIELD_GLYPHS_1 = 0xA6 + 0x4E0,
            PLAYER_GLYPHS_ENABLED = 0xA6 + 0x4E9,
            PLAYER_PET_SPELL_POWER = 0xA6 + 0x4EA,
            PLAYER_FIELD_RESEARCHING_1 = 0xA6 + 0x4EB,
            PLAYER_FIELD_RESERACH_SITE_1 = 0xA6 + 0x4F3,
            PLAYER_PROFESSION_SKILL_LINE_1 = 0xA6 + 0x4FB,
            PLAYER_FIELD_UI_HIT_MODIFIER = 0xA6 + 0x4FD,
            PLAYER_FIELD_UI_SPELL_HIT_MODIFIER = 0xA6 + 0x4FE,
            PLAYER_FIELD_HOME_REALM_TIME_OFFSET = 0xA6 + 0x4FF,
        };

        #endregion

#pragma warning restore 1591

    }
}
