// Auto generated file
// Patch: 0.6.0
// Build: 3592

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
    ITEM_FIELD_STACK_COUNT = EObjectFields.OBJECT_END + 0x6,                      // 0x00C - Size: 1 - Type: INT - Flags: OWNER_ONLY + UNK2
    ITEM_FIELD_DURATION = EObjectFields.OBJECT_END + 0x7,                         // 0x00D - Size: 1 - Type: INT - Flags: OWNER_ONLY + UNK2
    ITEM_FIELD_SPELL_CHARGES = EObjectFields.OBJECT_END + 0x8,                    // 0x00E - Size: 5 - Type: INT - Flags: OWNER_ONLY + UNK2
    ITEM_FIELD_FLAGS = EObjectFields.OBJECT_END + 0xD,                            // 0x013 - Size: 1 - Type: TWO_SHORT - Flags: PUBLIC
    ITEM_FIELD_ENCHANTMENT = EObjectFields.OBJECT_END + 0xE,                      // 0x014 - Size: 21 - Type: INT - Flags: PUBLIC
    ITEM_FIELD_PROPERTY_SEED = EObjectFields.OBJECT_END + 0x23,                   // 0x029 - Size: 1 - Type: INT - Flags: PUBLIC
    ITEM_FIELD_RANDOM_PROPERTIES_ID = EObjectFields.OBJECT_END + 0x24,            // 0x02A - Size: 1 - Type: INT - Flags: PUBLIC
    ITEM_FIELD_PAD = EObjectFields.OBJECT_END + 0x25,                             // 0x02B - Size: 1 - Type: INT - Flags: NONE
    ITEM_END = EObjectFields.OBJECT_END + 0x26                                    // 0x02C
}
Public Enum EContainerFields
{
    CONTAINER_FIELD_NUM_SLOTS = EItemFields.ITEM_END + 0x0,                       // 0x026 - Size: 1 - Type: INT - Flags: PUBLIC
    CONTAINER_ALIGN_PAD = EItemFields.ITEM_END + 0x1,                             // 0x027 - Size: 1 - Type: BYTES - Flags: NONE
    CONTAINER_FIELD_SLOT_1 = EItemFields.ITEM_END + 0x2,                          // 0x028 - Size: 40 - Type: GUID - Flags: PUBLIC
    CONTAINER_END = EItemFields.ITEM_END + 0x2A                                   // 0x050
}
Public Enum EUnitFields
{
    UNIT_FIELD_CHARM = EObjectFields.OBJECT_END + 0x0,                            // 0x006 - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_SUMMON = EObjectFields.OBJECT_END + 0x2,                           // 0x008 - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_CHARMEDBY = EObjectFields.OBJECT_END + 0x4,                        // 0x00A - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_SUMMONEDBY = EObjectFields.OBJECT_END + 0x6,                       // 0x00C - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_CREATEDBY = EObjectFields.OBJECT_END + 0x8,                        // 0x00E - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_TARGET = EObjectFields.OBJECT_END + 0xA,                           // 0x010 - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_COMBO_TARGET = EObjectFields.OBJECT_END + 0xC,                     // 0x012 - Size: 2 - Type: GUID - Flags: PRIVATE
    UNIT_FIELD_CHANNEL_OBJECT = EObjectFields.OBJECT_END + 0xE,                   // 0x014 - Size: 2 - Type: GUID - Flags: PUBLIC
    UNIT_FIELD_HEALTH = EObjectFields.OBJECT_END + 0x10,                          // 0x016 - Size: 1 - Type: INT - Flags: DYNAMIC
    UNIT_FIELD_POWER1 = EObjectFields.OBJECT_END + 0x11,                          // 0x017 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_POWER2 = EObjectFields.OBJECT_END + 0x12,                          // 0x018 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_POWER3 = EObjectFields.OBJECT_END + 0x13,                          // 0x019 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_POWER4 = EObjectFields.OBJECT_END + 0x14,                          // 0x01A - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MAXHEALTH = EObjectFields.OBJECT_END + 0x15,                       // 0x01B - Size: 1 - Type: INT - Flags: DYNAMIC
    UNIT_FIELD_MAXPOWER1 = EObjectFields.OBJECT_END + 0x16,                       // 0x01C - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MAXPOWER2 = EObjectFields.OBJECT_END + 0x17,                       // 0x01D - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MAXPOWER3 = EObjectFields.OBJECT_END + 0x18,                       // 0x01E - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MAXPOWER4 = EObjectFields.OBJECT_END + 0x19,                       // 0x01F - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_LEVEL = EObjectFields.OBJECT_END + 0x1A,                           // 0x020 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_FACTIONTEMPLATE = EObjectFields.OBJECT_END + 0x1B,                 // 0x021 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_BYTES_0 = EObjectFields.OBJECT_END + 0x1C,                         // 0x022 - Size: 1 - Type: BYTES - Flags: PUBLIC
    UNIT_FIELD_STAT0 = EObjectFields.OBJECT_END + 0x1D,                           // 0x023 - Size: 1 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_STAT1 = EObjectFields.OBJECT_END + 0x1E,                           // 0x024 - Size: 1 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_STAT2 = EObjectFields.OBJECT_END + 0x1F,                           // 0x025 - Size: 1 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_STAT3 = EObjectFields.OBJECT_END + 0x20,                           // 0x026 - Size: 1 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_STAT4 = EObjectFields.OBJECT_END + 0x21,                           // 0x027 - Size: 1 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_BASESTAT0 = EObjectFields.OBJECT_END + 0x22,                       // 0x028 - Size: 1 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_BASESTAT1 = EObjectFields.OBJECT_END + 0x23,                       // 0x029 - Size: 1 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_BASESTAT2 = EObjectFields.OBJECT_END + 0x24,                       // 0x02A - Size: 1 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_BASESTAT3 = EObjectFields.OBJECT_END + 0x25,                       // 0x02B - Size: 1 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_BASESTAT4 = EObjectFields.OBJECT_END + 0x26,                       // 0x02C - Size: 1 - Type: INT - Flags: PRIVATE
    UNIT_VIRTUAL_ITEM_SLOT_DISPLAY = EObjectFields.OBJECT_END + 0x27,             // 0x02D - Size: 3 - Type: INT - Flags: PUBLIC
    UNIT_VIRTUAL_ITEM_INFO = EObjectFields.OBJECT_END + 0x2A,                     // 0x030 - Size: 6 - Type: BYTES - Flags: PUBLIC
    UNIT_FIELD_FLAGS = EObjectFields.OBJECT_END + 0x30,                           // 0x036 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_COINAGE = EObjectFields.OBJECT_END + 0x31,                         // 0x037 - Size: 1 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_AURA = EObjectFields.OBJECT_END + 0x32,                            // 0x038 - Size: 56 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_AURALEVELS = EObjectFields.OBJECT_END + 0x6A,                      // 0x070 - Size: 10 - Type: BYTES - Flags: PUBLIC
    UNIT_FIELD_AURAAPPLICATIONS = EObjectFields.OBJECT_END + 0x74,                // 0x07A - Size: 10 - Type: BYTES - Flags: PUBLIC
    UNIT_FIELD_AURAFLAGS = EObjectFields.OBJECT_END + 0x7E,                       // 0x084 - Size: 7 - Type: BYTES - Flags: PUBLIC
    UNIT_FIELD_AURASTATE = EObjectFields.OBJECT_END + 0x85,                       // 0x08B - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_BASEATTACKTIME = EObjectFields.OBJECT_END + 0x86,                  // 0x08C - Size: 2 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_RESISTANCES = EObjectFields.OBJECT_END + 0x88,                     // 0x08E - Size: 6 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_BOUNDINGRADIUS = EObjectFields.OBJECT_END + 0x8E,                  // 0x094 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    UNIT_FIELD_COMBATREACH = EObjectFields.OBJECT_END + 0x8F,                     // 0x095 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    UNIT_FIELD_WEAPONREACH = EObjectFields.OBJECT_END + 0x90,                     // 0x096 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    UNIT_FIELD_DISPLAYID = EObjectFields.OBJECT_END + 0x91,                       // 0x097 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MOUNTDISPLAYID = EObjectFields.OBJECT_END + 0x92,                  // 0x098 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MINDAMAGE = EObjectFields.OBJECT_END + 0x93,                       // 0x099 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    UNIT_FIELD_MAXDAMAGE = EObjectFields.OBJECT_END + 0x94,                       // 0x09A - Size: 1 - Type: FLOAT - Flags: PUBLIC
    UNIT_FIELD_MOD_DAMAGE_DONE = EObjectFields.OBJECT_END + 0x95,                 // 0x09B - Size: 6 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE = EObjectFields.OBJECT_END + 0x9B,      // 0x0A1 - Size: 6 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE = EObjectFields.OBJECT_END + 0xA1,      // 0x0A7 - Size: 6 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_RESISTANCEITEMMODS = EObjectFields.OBJECT_END + 0xA7,              // 0x0AD - Size: 6 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_BYTES_1 = EObjectFields.OBJECT_END + 0xAD,                         // 0x0B3 - Size: 1 - Type: BYTES - Flags: PUBLIC
    UNIT_FIELD_PETNUMBER = EObjectFields.OBJECT_END + 0xAE,                       // 0x0B4 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_PET_NAME_TIMESTAMP = EObjectFields.OBJECT_END + 0xAF,              // 0x0B5 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_PETEXPERIENCE = EObjectFields.OBJECT_END + 0xB0,                   // 0x0B6 - Size: 1 - Type: INT - Flags: OWNER_ONLY
    UNIT_FIELD_PETNEXTLEVELEXP = EObjectFields.OBJECT_END + 0xB1,                 // 0x0B7 - Size: 1 - Type: INT - Flags: OWNER_ONLY
    UNIT_DYNAMIC_FLAGS = EObjectFields.OBJECT_END + 0xB2,                         // 0x0B8 - Size: 1 - Type: INT - Flags: DYNAMIC
    UNIT_EMOTE_STATE = EObjectFields.OBJECT_END + 0xB3,                           // 0x0B9 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_CHANNEL_SPELL = EObjectFields.OBJECT_END + 0xB4,                         // 0x0BA - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_MOD_CAST_SPEED = EObjectFields.OBJECT_END + 0xB5,                        // 0x0BB - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_CREATED_BY_SPELL = EObjectFields.OBJECT_END + 0xB6,                      // 0x0BC - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_NPC_FLAGS = EObjectFields.OBJECT_END + 0xB7,                             // 0x0BD - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_BYTES_2 = EObjectFields.OBJECT_END + 0xB8,                         // 0x0BE - Size: 1 - Type: BYTES - Flags: PRIVATE
    UNIT_FIELD_ATTACKPOWER = EObjectFields.OBJECT_END + 0xB9,                     // 0x0BF - Size: 1 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_ATTACKPOWERMODIFIER = EObjectFields.OBJECT_END + 0xBA,             // 0x0C0 - Size: 1 - Type: INT - Flags: PRIVATE
    UNIT_FIELD_PADDING = EObjectFields.OBJECT_END + 0xBB,                         // 0x0C1 - Size: 1 - Type: INT - Flags: NONE
    UNIT_END = EObjectFields.OBJECT_END + 0xBC                                    // 0x0C2
}
Public Enum EPlayerFields
{
    PLAYER_SELECTION = EUnitFields.UNIT_END + 0x0,                                // 0x0BC - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_DUEL_ARBITER = EUnitFields.UNIT_END + 0x2,                             // 0x0BE - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_GUILDID = EUnitFields.UNIT_END + 0x4,                                  // 0x0C0 - Size: 1 - Type: INT - Flags: PUBLIC
    PLAYER_GUILDRANK = EUnitFields.UNIT_END + 0x5,                                // 0x0C1 - Size: 1 - Type: INT - Flags: PUBLIC
    PLAYER_BYTES = EUnitFields.UNIT_END + 0x6,                                    // 0x0C2 - Size: 1 - Type: BYTES - Flags: PUBLIC
    PLAYER_BYTES_2 = EUnitFields.UNIT_END + 0x7,                                  // 0x0C3 - Size: 1 - Type: BYTES - Flags: PUBLIC
    PLAYER_DUEL_TEAM = EUnitFields.UNIT_END + 0x8,                                // 0x0C4 - Size: 1 - Type: INT - Flags: PUBLIC
    PLAYER_GUILD_TIMESTAMP = EUnitFields.UNIT_END + 0x9,                          // 0x0C5 - Size: 1 - Type: INT - Flags: PUBLIC
    PLAYER_FIELD_INV_SLOT_HEAD = EUnitFields.UNIT_END + 0xA,                      // 0x0C6 - Size: 46 - Type: GUID - Flags: PUBLIC
    PLAYER_FIELD_PACK_SLOT_1 = EUnitFields.UNIT_END + 0x38,                       // 0x0F4 - Size: 32 - Type: GUID - Flags: PRIVATE
    PLAYER_FIELD_BANK_SLOT_1 = EUnitFields.UNIT_END + 0x58,                       // 0x114 - Size: 48 - Type: GUID - Flags: PRIVATE
    PLAYER_FIELD_BANKBAG_SLOT_1 = EUnitFields.UNIT_END + 0x88,                    // 0x144 - Size: 12 - Type: GUID - Flags: PRIVATE
    PLAYER_FARSIGHT = EUnitFields.UNIT_END + 0x94,                                // 0x150 - Size: 2 - Type: GUID - Flags: PRIVATE
    PLAYER_XP = EUnitFields.UNIT_END + 0x96,                                      // 0x152 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_NEXT_LEVEL_XP = EUnitFields.UNIT_END + 0x97,                           // 0x153 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_SKILL_INFO_1_1 = EUnitFields.UNIT_END + 0x98,                          // 0x154 - Size: 384 - Type: TWO_SHORT - Flags: PRIVATE
    PLAYER_QUEST_LOG_1_1 = EUnitFields.UNIT_END + 0x218,                          // 0x2D4 - Size: 80 - Type: INT - Flags: PRIVATE
    PLAYER_CHARACTER_POINTS1 = EUnitFields.UNIT_END + 0x268,                      // 0x324 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_CHARACTER_POINTS2 = EUnitFields.UNIT_END + 0x269,                      // 0x325 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_TRACK_CREATURES = EUnitFields.UNIT_END + 0x26A,                        // 0x326 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_TRACK_RESOURCES = EUnitFields.UNIT_END + 0x26B,                        // 0x327 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_CHAT_FILTERS = EUnitFields.UNIT_END + 0x26C,                           // 0x328 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_BLOCK_PERCENTAGE = EUnitFields.UNIT_END + 0x26D,                       // 0x329 - Size: 1 - Type: FLOAT - Flags: PRIVATE
    PLAYER_DODGE_PERCENTAGE = EUnitFields.UNIT_END + 0x26E,                       // 0x32A - Size: 1 - Type: FLOAT - Flags: PRIVATE
    PLAYER_PARRY_PERCENTAGE = EUnitFields.UNIT_END + 0x26F,                       // 0x32B - Size: 1 - Type: FLOAT - Flags: PRIVATE
    PLAYER_BASE_MANA = EUnitFields.UNIT_END + 0x270,                              // 0x32C - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_EXPLORED_ZONES_1 = EUnitFields.UNIT_END + 0x271,                       // 0x32D - Size: 32 - Type: BYTES - Flags: PRIVATE
    PLAYER_REST_STATE_EXPERIENCE = EUnitFields.UNIT_END + 0x291,                  // 0x34D - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_END = EUnitFields.UNIT_END + 0x292                                     // 0x34E
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
    GAMEOBJECT_END = EObjectFields.OBJECT_END + 0xE                               // 0x014
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
