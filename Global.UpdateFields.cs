// Auto generated file
// Patch: 0.10.0
// Build: 3892

Public Enum EObjectFields
{
    OBJECT_FIELD_GUID = 0x0,                                                      // 0x000 - Size: 2 - Type: GUID - Flags: PUBLIC
    OBJECT_FIELD_TYPE = 0x2,                                                      // 0x002 - Size: 1 - Type: INT - Flags: PUBLIC
    OBJECT_FIELD_ENTRY = 0x3,                                                     // 0x003 - Size: 1 - Type: INT - Flags: PUBLIC
    OBJECT_FIELD_SCALE_X = 0x4,                                                   // 0x004 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    OBJECT_FIELD_PADDING = 0x5,                                                   // 0x005 - Size: 1 - Type: INT - Flags: PUBLIC
    OBJECT_END = 0x6                                                              
}
Public Enum EItemFields
{
    ITEM_FIELD_OWNER = EObjectFields.OBJECT_END + 0x0,                            // 0x006 - Size: 2 - Type: GUID - Flags: PUBLIC
    ITEM_FIELD_CONTAINED = EObjectFields.OBJECT_END + 0x2,                        // 0x008 - Size: 2 - Type: GUID - Flags: PUBLIC
    ITEM_FIELD_CREATOR = EObjectFields.OBJECT_END + 0x4,                          // 0x00A - Size: 2 - Type: GUID - Flags: PUBLIC
    ITEM_FIELD_GIFTCREATOR = EObjectFields.OBJECT_END + 0x6,                      // 0x00C - Size: 2 - Type: GUID - Flags: PUBLIC
    ITEM_FIELD_STACK_COUNT = EObjectFields.OBJECT_END + 0x8,                      // 0x00E - Size: 1 - Type: INT - Flags: OWNER_ONLY + UNK2
    ITEM_FIELD_DURATION = EObjectFields.OBJECT_END + 0x9,                         // 0x00F - Size: 1 - Type: INT - Flags: OWNER_ONLY + UNK2
    ITEM_FIELD_SPELL_CHARGES = EObjectFields.OBJECT_END + 0xA,                    // 0x010 - Size: 5 - Type: INT - Flags: OWNER_ONLY + UNK2
    ITEM_FIELD_FLAGS = EObjectFields.OBJECT_END + 0xF,                            // 0x015 - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    ITEM_FIELD_ENCHANTMENT = EObjectFields.OBJECT_END + 0x10,                     // 0x016 - Size: 21 - Type: INT - Flags: PUBLIC
    ITEM_FIELD_PROPERTY_SEED = EObjectFields.OBJECT_END + 0x25,                   // 0x02B - Size: 1 - Type: INT - Flags: PUBLIC
    ITEM_FIELD_RANDOM_PROPERTIES_ID = EObjectFields.OBJECT_END + 0x26,            // 0x02C - Size: 1 - Type: INT - Flags: PUBLIC
    ITEM_FIELD_ITEM_TEXT_ID = EObjectFields.OBJECT_END + 0x27,                    // 0x02D - Size: 1 - Type: INT - Flags: OWNER_ONLY
    ITEM_FIELD_DURABILITY = EObjectFields.OBJECT_END + 0x28,                      // 0x02E - Size: 1 - Type: INT - Flags: OWNER_ONLY + UNK2
    ITEM_FIELD_MAXDURABILITY = EObjectFields.OBJECT_END + 0x29,                   // 0x02F - Size: 1 - Type: INT - Flags: OWNER_ONLY + UNK2
    ITEM_END = EObjectFields.OBJECT_END + 0x2A                                    // 0x030
}
Public Enum EContainerFields
{
    CONTAINER_FIELD_NUM_SLOTS = EItemFields.ITEM_END + 0x0,                       // 0x02A - Size: 1 - Type: INT - Flags: PUBLIC
    CONTAINER_ALIGN_PAD = EItemFields.ITEM_END + 0x1,                             // 0x02B - Size: 1 - Type: BYTES - Flags: NONE
    CONTAINER_FIELD_SLOT_1 = EItemFields.ITEM_END + 0x2,                          // 0x02C - Size: 40 - Type: GUID - Flags: PUBLIC
    CONTAINER_END = EItemFields.ITEM_END + 0x2A                                   // 0x054
}
Public Enum EUnitFields
{
    UNIT_FIELD_CHARM = EObjectFields.OBJECT_END + 0x0,                            // 0x006 - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_SUMMON = EObjectFields.OBJECT_END + 0x2,                           // 0x008 - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_CHARMEDBY = EObjectFields.OBJECT_END + 0x4,                        // 0x00A - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_SUMMONEDBY = EObjectFields.OBJECT_END + 0x6,                       // 0x00C - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_CREATEDBY = EObjectFields.OBJECT_END + 0x8,                        // 0x00E - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_TARGET = EObjectFields.OBJECT_END + 0xA,                           // 0x010 - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_CHANNEL_OBJECT = EObjectFields.OBJECT_END + 0xC,                   // 0x012 - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_HEALTH = EObjectFields.OBJECT_END + 0xE,                           // 0x014 - Size: 1 - Type: INT - Flags: DYNAMIC
    UNIT_FIELD_POWER1 = EObjectFields.OBJECT_END + 0xF,                           // 0x015 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_POWER2 = EObjectFields.OBJECT_END + 0x10,                          // 0x016 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_POWER3 = EObjectFields.OBJECT_END + 0x11,                          // 0x017 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_POWER4 = EObjectFields.OBJECT_END + 0x12,                          // 0x018 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_POWER5 = EObjectFields.OBJECT_END + 0x13,                          // 0x019 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MAXHEALTH = EObjectFields.OBJECT_END + 0x14,                       // 0x01A - Size: 1 - Type: INT - Flags: DYNAMIC
    UNIT_FIELD_MAXPOWER1 = EObjectFields.OBJECT_END + 0x15,                       // 0x01B - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MAXPOWER2 = EObjectFields.OBJECT_END + 0x16,                       // 0x01C - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MAXPOWER3 = EObjectFields.OBJECT_END + 0x17,                       // 0x01D - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MAXPOWER4 = EObjectFields.OBJECT_END + 0x18,                       // 0x01E - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MAXPOWER5 = EObjectFields.OBJECT_END + 0x19,                       // 0x01F - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_LEVEL = EObjectFields.OBJECT_END + 0x1A,                           // 0x020 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_FACTIONTEMPLATE = EObjectFields.OBJECT_END + 0x1B,                 // 0x021 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_BYTES_0 = EObjectFields.OBJECT_END + 0x1C,                         // 0x022 - Size: 1 - Type: BYTES - Flags: PUBLIC
    UNIT_VIRTUAL_ITEM_SLOT_DISPLAY = EObjectFields.OBJECT_END + 0x1D,             // 0x023 - Size: 3 - Type: INT - Flags: PUBLIC
    UNIT_VIRTUAL_ITEM_INFO = EObjectFields.OBJECT_END + 0x20,                     // 0x026 - Size: 6 - Type: BYTES - Flags: PUBLIC
    UNIT_FIELD_FLAGS = EObjectFields.OBJECT_END + 0x26,                           // 0x02C - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_AURA = EObjectFields.OBJECT_END + 0x27,                            // 0x02D - Size: 56 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_AURALEVELS = EObjectFields.OBJECT_END + 0x5F,                      // 0x065 - Size: 10 - Type: BYTES - Flags: PUBLIC
    UNIT_FIELD_AURAAPPLICATIONS = EObjectFields.OBJECT_END + 0x69,                // 0x06F - Size: 10 - Type: BYTES - Flags: PUBLIC
    UNIT_FIELD_AURAFLAGS = EObjectFields.OBJECT_END + 0x73,                       // 0x079 - Size: 7 - Type: BYTES - Flags: PUBLIC
    UNIT_FIELD_AURASTATE = EObjectFields.OBJECT_END + 0x7A,                       // 0x080 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_BASEATTACKTIME = EObjectFields.OBJECT_END + 0x7B,                  // 0x081 - Size: 2 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_BOUNDINGRADIUS = EObjectFields.OBJECT_END + 0x7D,                  // 0x083 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    UNIT_FIELD_COMBATREACH = EObjectFields.OBJECT_END + 0x7E,                     // 0x084 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    UNIT_FIELD_DISPLAYID = EObjectFields.OBJECT_END + 0x7F,                       // 0x085 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_NATIVEDISPLAYID = EObjectFields.OBJECT_END + 0x80,                 // 0x086 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MOUNTDISPLAYID = EObjectFields.OBJECT_END + 0x81,                  // 0x087 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MINDAMAGE = EObjectFields.OBJECT_END + 0x82,                       // 0x088 - Size: 1 - Type: FLOAT - Flags: PRIVATE + OWNER_ONLY + UNK3
    UNIT_FIELD_MAXDAMAGE = EObjectFields.OBJECT_END + 0x83,                       // 0x089 - Size: 1 - Type: FLOAT - Flags: PRIVATE + OWNER_ONLY + UNK3
    UNIT_FIELD_BYTES_1 = EObjectFields.OBJECT_END + 0x84,                         // 0x08A - Size: 1 - Type: BYTES - Flags: PUBLIC
    UNIT_FIELD_PETNUMBER = EObjectFields.OBJECT_END + 0x85,                       // 0x08B - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_PET_NAME_TIMESTAMP = EObjectFields.OBJECT_END + 0x86,              // 0x08C - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_PETEXPERIENCE = EObjectFields.OBJECT_END + 0x87,                   // 0x08D - Size: 1 - Type: INT - Flags: OWNER_ONLY
    UNIT_FIELD_PETNEXTLEVELEXP = EObjectFields.OBJECT_END + 0x88,                 // 0x08E - Size: 1 - Type: INT - Flags: OWNER_ONLY
    UNIT_DYNAMIC_FLAGS = EObjectFields.OBJECT_END + 0x89,                         // 0x08F - Size: 1 - Type: INT - Flags: DYNAMIC
    UNIT_CHANNEL_SPELL = EObjectFields.OBJECT_END + 0x8A,                         // 0x090 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_MOD_CAST_SPEED = EObjectFields.OBJECT_END + 0x8B,                        // 0x091 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_CREATED_BY_SPELL = EObjectFields.OBJECT_END + 0x8C,                      // 0x092 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_NPC_FLAGS = EObjectFields.OBJECT_END + 0x8D,                             // 0x093 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_NPC_EMOTESTATE = EObjectFields.OBJECT_END + 0x8E,                        // 0x094 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_TRAINING_POINTS = EObjectFields.OBJECT_END + 0x8F,                       // 0x095 - Size: 1 - Type: TWO_SHORT - Flags: OWNER_ONLY
    UNIT_FIELD_STAT0 = EObjectFields.OBJECT_END + 0x90,                           // 0x096 - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_STAT1 = EObjectFields.OBJECT_END + 0x91,                           // 0x097 - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_STAT2 = EObjectFields.OBJECT_END + 0x92,                           // 0x098 - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_STAT3 = EObjectFields.OBJECT_END + 0x93,                           // 0x099 - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_STAT4 = EObjectFields.OBJECT_END + 0x94,                           // 0x09A - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_RESISTANCES = EObjectFields.OBJECT_END + 0x95,                     // 0x09B - Size: 7 - Type: INT - Flags: PRIVATE + OWNER_ONLY + UNK3
    UNIT_FIELD_ATTACKPOWER = EObjectFields.OBJECT_END + 0x9C,                     // 0x0A2 - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_BASE_MANA = EObjectFields.OBJECT_END + 0x9D,                       // 0x0A3 - Size: 1 - Type: INT - Flags: PRIVATE + OWNER_ONLY
    UNIT_ATTACK_POWER_MODS = EObjectFields.OBJECT_END + 0x9E,                     // 0x0A4 - Size: 1 - Type: TWO_SHORT - Flags: PRIVATE + OWNER_ONLY
    UNIT_FIELD_PADDING = EObjectFields.OBJECT_END + 0x9F,                         // 0x0A5 - Size: 1 - Type: INT - Flags: NONE
    UNIT_END = EObjectFields.OBJECT_END + 0xA0                                    // 0x0A6
}
Public Enum EPlayerFields
{
    PLAYER_SELECTION = EUnitFields.UNIT_END + 0x0,                                // 0x0A0 - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_DUEL_ARBITER = EUnitFields.UNIT_END + 0x2,                             // 0x0A2 - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_GUILDID = EUnitFields.UNIT_END + 0x4,                                  // 0x0A4 - Size: 1 - Type: INT - Flags: PUBLIC
    PLAYER_GUILDRANK = EUnitFields.UNIT_END + 0x5,                                // 0x0A5 - Size: 1 - Type: INT - Flags: PUBLIC
    PLAYER_BYTES = EUnitFields.UNIT_END + 0x6,                                    // 0x0A6 - Size: 1 - Type: BYTES - Flags: PUBLIC
    PLAYER_BYTES_2 = EUnitFields.UNIT_END + 0x7,                                  // 0x0A7 - Size: 1 - Type: BYTES - Flags: PUBLIC
    PLAYER_BYTES_3 = EUnitFields.UNIT_END + 0x8,                                  // 0x0A8 - Size: 1 - Type: BYTES - Flags: PUBLIC
    PLAYER_DUEL_TEAM = EUnitFields.UNIT_END + 0x9,                                // 0x0A9 - Size: 1 - Type: INT - Flags: PUBLIC
    PLAYER_GUILD_TIMESTAMP = EUnitFields.UNIT_END + 0xA,                          // 0x0AA - Size: 1 - Type: INT - Flags: PUBLIC
    PLAYER_FIELD_PAD_0 = EUnitFields.UNIT_END + 0xB,                              // 0x0AB - Size: 1 - Type: INT - Flags: NONE
    PLAYER_FIELD_INV_SLOT_HEAD = EUnitFields.UNIT_END + 0xC,                      // 0x0AC - Size: 46 - Type: GUID - Flags: PUBLIC
    PLAYER_FIELD_PACK_SLOT_1 = EUnitFields.UNIT_END + 0x3A,                       // 0x0DA - Size: 32 - Type: GUID - Flags: PRIVATE
    PLAYER_FIELD_BANK_SLOT_1 = EUnitFields.UNIT_END + 0x5A,                       // 0x0FA - Size: 48 - Type: GUID - Flags: PRIVATE
    PLAYER_FIELD_BANKBAG_SLOT_1 = EUnitFields.UNIT_END + 0x8A,                    // 0x12A - Size: 12 - Type: GUID - Flags: PRIVATE
    PLAYER_FIELD_VENDORBUYBACK_SLOT = EUnitFields.UNIT_END + 0x96,                // 0x136 - Size: 2 - Type: GUID - Flags: PRIVATE
    PLAYER_FARSIGHT = EUnitFields.UNIT_END + 0x98,                                // 0x138 - Size: 2 - Type: GUID - Flags: PRIVATE
    PLAYER__FIELD_COMBO_TARGET = EUnitFields.UNIT_END + 0x9A,                     // 0x13A - Size: 2 - Type: GUID - Flags: PRIVATE
    PLAYER_FIELD_BUYBACK_NPC = EUnitFields.UNIT_END + 0x9C,                       // 0x13C - Size: 2 - Type: GUID - Flags: PRIVATE
    PLAYER_XP = EUnitFields.UNIT_END + 0x9E,                                      // 0x13E - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_NEXT_LEVEL_XP = EUnitFields.UNIT_END + 0x9F,                           // 0x13F - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_SKILL_INFO_1_1 = EUnitFields.UNIT_END + 0xA0,                          // 0x140 - Size: 384 - Type: TWO_SHORT - Flags: PRIVATE
    PLAYER_QUEST_LOG_1_1 = EUnitFields.UNIT_END + 0x220,                          // 0x2C0 - Size: 60 - Type: INT - Flags: PRIVATE
    PLAYER_CHARACTER_POINTS1 = EUnitFields.UNIT_END + 0x25C,                      // 0x2FC - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_CHARACTER_POINTS2 = EUnitFields.UNIT_END + 0x25D,                      // 0x2FD - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_TRACK_CREATURES = EUnitFields.UNIT_END + 0x25E,                        // 0x2FE - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_TRACK_RESOURCES = EUnitFields.UNIT_END + 0x25F,                        // 0x2FF - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_CHAT_FILTERS = EUnitFields.UNIT_END + 0x260,                           // 0x300 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_BLOCK_PERCENTAGE = EUnitFields.UNIT_END + 0x261,                       // 0x301 - Size: 1 - Type: FLOAT - Flags: PRIVATE
    PLAYER_DODGE_PERCENTAGE = EUnitFields.UNIT_END + 0x262,                       // 0x302 - Size: 1 - Type: FLOAT - Flags: PRIVATE
    PLAYER_PARRY_PERCENTAGE = EUnitFields.UNIT_END + 0x263,                       // 0x303 - Size: 1 - Type: FLOAT - Flags: PRIVATE
    PLAYER_CRIT_PERCENTAGE = EUnitFields.UNIT_END + 0x264,                        // 0x304 - Size: 1 - Type: FLOAT - Flags: PRIVATE
    PLAYER_EXPLORED_ZONES_1 = EUnitFields.UNIT_END + 0x265,                       // 0x305 - Size: 32 - Type: BYTES - Flags: PRIVATE
    PLAYER_REST_STATE_EXPERIENCE = EUnitFields.UNIT_END + 0x285,                  // 0x325 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_COINAGE = EUnitFields.UNIT_END + 0x286,                          // 0x326 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_POSSTAT0 = EUnitFields.UNIT_END + 0x287,                         // 0x327 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_POSSTAT1 = EUnitFields.UNIT_END + 0x288,                         // 0x328 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_POSSTAT2 = EUnitFields.UNIT_END + 0x289,                         // 0x329 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_POSSTAT3 = EUnitFields.UNIT_END + 0x28A,                         // 0x32A - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_POSSTAT4 = EUnitFields.UNIT_END + 0x28B,                         // 0x32B - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_NEGSTAT0 = EUnitFields.UNIT_END + 0x28C,                         // 0x32C - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_NEGSTAT1 = EUnitFields.UNIT_END + 0x28D,                         // 0x32D - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_NEGSTAT2 = EUnitFields.UNIT_END + 0x28E,                         // 0x32E - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_NEGSTAT3 = EUnitFields.UNIT_END + 0x28F,                         // 0x32F - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_NEGSTAT4 = EUnitFields.UNIT_END + 0x290,                         // 0x330 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_RESISTANCEBUFFMODSPOSITIVE = EUnitFields.UNIT_END + 0x291,       // 0x331 - Size: 7 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_RESISTANCEBUFFMODSNEGATIVE = EUnitFields.UNIT_END + 0x298,       // 0x338 - Size: 7 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_MOD_DAMAGE_DONE_POS = EUnitFields.UNIT_END + 0x29F,              // 0x33F - Size: 7 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_MOD_DAMAGE_DONE_NEG = EUnitFields.UNIT_END + 0x2A6,              // 0x346 - Size: 7 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_MOD_DAMAGE_DONE_PCT = EUnitFields.UNIT_END + 0x2AD,              // 0x34D - Size: 7 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BYTES = EUnitFields.UNIT_END + 0x2B4,                            // 0x354 - Size: 1 - Type: BYTES - Flags: PRIVATE
    PLAYER_AMMO_ID = EUnitFields.UNIT_END + 0x2B5,                                // 0x355 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_PVP_MEDALS = EUnitFields.UNIT_END + 0x2B6,                       // 0x356 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BUYBACK_ITEM_ID = EUnitFields.UNIT_END + 0x2B7,                  // 0x357 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BUYBACK_RANDOM_PROPERTIES_ID = EUnitFields.UNIT_END + 0x2B8,     // 0x358 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BUYBACK_SEED = EUnitFields.UNIT_END + 0x2B9,                     // 0x359 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BUYBACK_PRICE = EUnitFields.UNIT_END + 0x2BA,                    // 0x35A - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_PADDING = EUnitFields.UNIT_END + 0x2BB,                          // 0x35B - Size: 1 - Type: INT - Flags: NONE
    PLAYER_END = EUnitFields.UNIT_END + 0x2BC                                     // 0x35C
}
Public Enum EGameObjectFields
{
    GAMEOBJECT_DISPLAYID = EObjectFields.OBJECT_END + 0x0,                        // 0x006 - Size: 1 - Type: INT - Flags: PUBLIC
    GAMEOBJECT_FLAGS = EObjectFields.OBJECT_END + 0x1,                            // 0x007 - Size: 1 - Type: INT - Flags: PUBLIC
    GAMEOBJECT_ROTATION = EObjectFields.OBJECT_END + 0x2,                         // 0x008 - Size: 4 - Type: FLOAT - Flags: PUBLIC
    GAMEOBJECT_STATE = EObjectFields.OBJECT_END + 0x6,                            // 0x00C - Size: 1 - Type: INT - Flags: PUBLIC
    GAMEOBJECT_TIMESTAMP = EObjectFields.OBJECT_END + 0x7,                        // 0x00D - Size: 1 - Type: INT - Flags: PUBLIC
    GAMEOBJECT_POS_X = EObjectFields.OBJECT_END + 0x8,                            // 0x00E - Size: 1 - Type: FLOAT - Flags: PUBLIC
    GAMEOBJECT_POS_Y = EObjectFields.OBJECT_END + 0x9,                            // 0x00F - Size: 1 - Type: FLOAT - Flags: PUBLIC
    GAMEOBJECT_POS_Z = EObjectFields.OBJECT_END + 0xA,                            // 0x010 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    GAMEOBJECT_FACING = EObjectFields.OBJECT_END + 0xB,                           // 0x011 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    GAMEOBJECT_DYN_FLAGS = EObjectFields.OBJECT_END + 0xC,                        // 0x012 - Size: 1 - Type: INT - Flags: DYNAMIC
    GAMEOBJECT_FACTION = EObjectFields.OBJECT_END + 0xD,                          // 0x013 - Size: 1 - Type: INT - Flags: PUBLIC
    GAMEOBJECT_TYPE_ID = EObjectFields.OBJECT_END + 0xE,                          // 0x014 - Size: 1 - Type: INT - Flags: PUBLIC
    GAMEOBJECT_LEVEL = EObjectFields.OBJECT_END + 0xF,                            // 0x015 - Size: 1 - Type: INT - Flags: PUBLIC
    GAMEOBJECT_END = EObjectFields.OBJECT_END + 0x10                              // 0x016
}
Public Enum EDynamicObjectFields
{
    DYNAMICOBJECT_CASTER = EObjectFields.OBJECT_END + 0x0,                        // 0x006 - Size: 2 - Type: GUID - Flags: PUBLIC
    DYNAMICOBJECT_BYTES = EObjectFields.OBJECT_END + 0x2,                         // 0x008 - Size: 1 - Type: BYTES - Flags: PUBLIC
    DYNAMICOBJECT_SPELLID = EObjectFields.OBJECT_END + 0x3,                       // 0x009 - Size: 1 - Type: INT - Flags: PUBLIC
    DYNAMICOBJECT_RADIUS = EObjectFields.OBJECT_END + 0x4,                        // 0x00A - Size: 1 - Type: FLOAT - Flags: PUBLIC
    DYNAMICOBJECT_POS_X = EObjectFields.OBJECT_END + 0x5,                         // 0x00B - Size: 1 - Type: FLOAT - Flags: PUBLIC
    DYNAMICOBJECT_POS_Y = EObjectFields.OBJECT_END + 0x6,                         // 0x00C - Size: 1 - Type: FLOAT - Flags: PUBLIC
    DYNAMICOBJECT_POS_Z = EObjectFields.OBJECT_END + 0x7,                         // 0x00D - Size: 1 - Type: FLOAT - Flags: PUBLIC
    DYNAMICOBJECT_FACING = EObjectFields.OBJECT_END + 0x8,                        // 0x00E - Size: 1 - Type: FLOAT - Flags: PUBLIC
    DYNAMICOBJECT_PAD = EObjectFields.OBJECT_END + 0x9,                           // 0x00F - Size: 1 - Type: BYTES - Flags: PUBLIC
    DYNAMICOBJECT_END = EObjectFields.OBJECT_END + 0xA                            // 0x010
}
Public Enum ECorpseFields
{
    CORPSE_FIELD_OWNER = EObjectFields.OBJECT_END + 0x0,                          // 0x006 - Size: 2 - Type: GUID - Flags: PUBLIC
    CORPSE_FIELD_FACING = EObjectFields.OBJECT_END + 0x2,                         // 0x008 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    CORPSE_FIELD_POS_X = EObjectFields.OBJECT_END + 0x3,                          // 0x009 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    CORPSE_FIELD_POS_Y = EObjectFields.OBJECT_END + 0x4,                          // 0x00A - Size: 1 - Type: FLOAT - Flags: PUBLIC
    CORPSE_FIELD_POS_Z = EObjectFields.OBJECT_END + 0x5,                          // 0x00B - Size: 1 - Type: FLOAT - Flags: PUBLIC
    CORPSE_FIELD_DISPLAY_ID = EObjectFields.OBJECT_END + 0x6,                     // 0x00C - Size: 1 - Type: INT - Flags: PUBLIC
    CORPSE_FIELD_ITEM = EObjectFields.OBJECT_END + 0x7,                           // 0x00D - Size: 19 - Type: INT - Flags: PUBLIC
    CORPSE_FIELD_BYTES_1 = EObjectFields.OBJECT_END + 0x1A,                       // 0x020 - Size: 1 - Type: BYTES - Flags: PUBLIC
    CORPSE_FIELD_BYTES_2 = EObjectFields.OBJECT_END + 0x1B,                       // 0x021 - Size: 1 - Type: BYTES - Flags: PUBLIC
    CORPSE_FIELD_GUILD = EObjectFields.OBJECT_END + 0x1C,                         // 0x022 - Size: 1 - Type: INT - Flags: PUBLIC
    CORPSE_FIELD_FLAGS = EObjectFields.OBJECT_END + 0x1D,                         // 0x023 - Size: 1 - Type: INT - Flags: PUBLIC
    CORPSE_END = EObjectFields.OBJECT_END + 0x1E                                  // 0x024
}
