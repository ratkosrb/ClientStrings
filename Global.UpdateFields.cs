// Auto generated file
// Patch: 0.7.0
// Build: 3694

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
    ITEM_END = EObjectFields.OBJECT_END + 0x28                                    // 0x02E
}
Public Enum EContainerFields
{
    CONTAINER_FIELD_NUM_SLOTS = EItemFields.ITEM_END + 0x0,                       // 0x028 - Size: 1 - Type: INT - Flags: PUBLIC
    CONTAINER_ALIGN_PAD = EItemFields.ITEM_END + 0x1,                             // 0x029 - Size: 1 - Type: BYTES - Flags: NONE
    CONTAINER_FIELD_SLOT_1 = EItemFields.ITEM_END + 0x2,                          // 0x02A - Size: 40 - Type: GUID - Flags: PUBLIC
    CONTAINER_END = EItemFields.ITEM_END + 0x2A                                   // 0x052
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
    UNIT_FIELD_WEAPONREACH = EObjectFields.OBJECT_END + 0x7F,                     // 0x085 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    UNIT_FIELD_DISPLAYID = EObjectFields.OBJECT_END + 0x80,                       // 0x086 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MOUNTDISPLAYID = EObjectFields.OBJECT_END + 0x81,                  // 0x087 - Size: 1 - Type: INT - Flags: PUBLIC
    UNIT_FIELD_MINDAMAGE = EObjectFields.OBJECT_END + 0x82,                       // 0x088 - Size: 1 - Type: FLOAT - Flags: PUBLIC
    UNIT_FIELD_MAXDAMAGE = EObjectFields.OBJECT_END + 0x83,                       // 0x089 - Size: 1 - Type: FLOAT - Flags: PUBLIC
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
    UNIT_FIELD_PADDING = EObjectFields.OBJECT_END + 0x8F,                         // 0x095 - Size: 1 - Type: INT - Flags: NONE
    UNIT_END = EObjectFields.OBJECT_END + 0x90                                    // 0x096
}
Public Enum EPlayerFields
{
    PLAYER_SELECTION = EUnitFields.UNIT_END + 0x0,                                // 0x090 - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_DUEL_ARBITER = EUnitFields.UNIT_END + 0x2,                             // 0x092 - Size: 2 - Type: GUID - Flags: PUBLIC
    PLAYER_GUILDID = EUnitFields.UNIT_END + 0x4,                                  // 0x094 - Size: 1 - Type: INT - Flags: PUBLIC
    PLAYER_GUILDRANK = EUnitFields.UNIT_END + 0x5,                                // 0x095 - Size: 1 - Type: INT - Flags: PUBLIC
    PLAYER_BYTES = EUnitFields.UNIT_END + 0x6,                                    // 0x096 - Size: 1 - Type: BYTES - Flags: PUBLIC
    PLAYER_BYTES_2 = EUnitFields.UNIT_END + 0x7,                                  // 0x097 - Size: 1 - Type: BYTES - Flags: PUBLIC
    PLAYER_BYTES_3 = EUnitFields.UNIT_END + 0x8,                                  // 0x098 - Size: 1 - Type: BYTES - Flags: PUBLIC
    PLAYER_DUEL_TEAM = EUnitFields.UNIT_END + 0x9,                                // 0x099 - Size: 1 - Type: INT - Flags: PUBLIC
    PLAYER_GUILD_TIMESTAMP = EUnitFields.UNIT_END + 0xA,                          // 0x09A - Size: 1 - Type: INT - Flags: PUBLIC
    PLAYER_FIELD_PAD_0 = EUnitFields.UNIT_END + 0xB,                              // 0x09B - Size: 1 - Type: INT - Flags: NONE
    PLAYER_FIELD_INV_SLOT_HEAD = EUnitFields.UNIT_END + 0xC,                      // 0x09C - Size: 46 - Type: GUID - Flags: PUBLIC
    PLAYER_FIELD_PACK_SLOT_1 = EUnitFields.UNIT_END + 0x3A,                       // 0x0CA - Size: 32 - Type: GUID - Flags: PRIVATE
    PLAYER_FIELD_BANK_SLOT_1 = EUnitFields.UNIT_END + 0x5A,                       // 0x0EA - Size: 48 - Type: GUID - Flags: PRIVATE
    PLAYER_FIELD_BANKBAG_SLOT_1 = EUnitFields.UNIT_END + 0x8A,                    // 0x11A - Size: 12 - Type: GUID - Flags: PRIVATE
    PLAYER_FARSIGHT = EUnitFields.UNIT_END + 0x96,                                // 0x126 - Size: 2 - Type: GUID - Flags: PRIVATE
    PLAYER__FIELD_COMBO_TARGET = EUnitFields.UNIT_END + 0x98,                     // 0x128 - Size: 2 - Type: GUID - Flags: PRIVATE
    PLAYER_XP = EUnitFields.UNIT_END + 0x9A,                                      // 0x12A - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_NEXT_LEVEL_XP = EUnitFields.UNIT_END + 0x9B,                           // 0x12B - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_SKILL_INFO_1_1 = EUnitFields.UNIT_END + 0x9C,                          // 0x12C - Size: 384 - Type: TWO_SHORT - Flags: PRIVATE
    PLAYER_QUEST_LOG_1_1 = EUnitFields.UNIT_END + 0x21C,                          // 0x2AC - Size: 80 - Type: INT - Flags: PRIVATE
    PLAYER_CHARACTER_POINTS1 = EUnitFields.UNIT_END + 0x26C,                      // 0x2FC - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_CHARACTER_POINTS2 = EUnitFields.UNIT_END + 0x26D,                      // 0x2FD - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_TRACK_CREATURES = EUnitFields.UNIT_END + 0x26E,                        // 0x2FE - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_TRACK_RESOURCES = EUnitFields.UNIT_END + 0x26F,                        // 0x2FF - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_CHAT_FILTERS = EUnitFields.UNIT_END + 0x270,                           // 0x300 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_BLOCK_PERCENTAGE = EUnitFields.UNIT_END + 0x271,                       // 0x301 - Size: 1 - Type: FLOAT - Flags: PRIVATE
    PLAYER_DODGE_PERCENTAGE = EUnitFields.UNIT_END + 0x272,                       // 0x302 - Size: 1 - Type: FLOAT - Flags: PRIVATE
    PLAYER_PARRY_PERCENTAGE = EUnitFields.UNIT_END + 0x273,                       // 0x303 - Size: 1 - Type: FLOAT - Flags: PRIVATE
    PLAYER_BASE_MANA = EUnitFields.UNIT_END + 0x274,                              // 0x304 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_EXPLORED_ZONES_1 = EUnitFields.UNIT_END + 0x275,                       // 0x305 - Size: 32 - Type: BYTES - Flags: PRIVATE
    PLAYER_REST_STATE_EXPERIENCE = EUnitFields.UNIT_END + 0x295,                  // 0x325 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_COINAGE = EUnitFields.UNIT_END + 0x296,                          // 0x326 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_STAT0 = EUnitFields.UNIT_END + 0x297,                            // 0x327 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_STAT1 = EUnitFields.UNIT_END + 0x298,                            // 0x328 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_STAT2 = EUnitFields.UNIT_END + 0x299,                            // 0x329 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_STAT3 = EUnitFields.UNIT_END + 0x29A,                            // 0x32A - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_STAT4 = EUnitFields.UNIT_END + 0x29B,                            // 0x32B - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BASESTAT0 = EUnitFields.UNIT_END + 0x29C,                        // 0x32C - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BASESTAT1 = EUnitFields.UNIT_END + 0x29D,                        // 0x32D - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BASESTAT2 = EUnitFields.UNIT_END + 0x29E,                        // 0x32E - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BASESTAT3 = EUnitFields.UNIT_END + 0x29F,                        // 0x32F - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BASESTAT4 = EUnitFields.UNIT_END + 0x2A0,                        // 0x330 - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_RESISTANCES = EUnitFields.UNIT_END + 0x2A1,                      // 0x331 - Size: 6 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_RESISTANCEBUFFMODSPOSITIVE = EUnitFields.UNIT_END + 0x2A7,       // 0x337 - Size: 6 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_RESISTANCEBUFFMODSNEGATIVE = EUnitFields.UNIT_END + 0x2AD,       // 0x33D - Size: 6 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_MOD_DAMAGE_DONE = EUnitFields.UNIT_END + 0x2B3,                  // 0x343 - Size: 6 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_BYTES = EUnitFields.UNIT_END + 0x2B9,                            // 0x349 - Size: 1 - Type: BYTES - Flags: PRIVATE
    PLAYER_FIELD_ATTACKPOWER = EUnitFields.UNIT_END + 0x2BA,                      // 0x34A - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_FIELD_ATTACKPOWERMODIFIER = EUnitFields.UNIT_END + 0x2BB,              // 0x34B - Size: 1 - Type: INT - Flags: PRIVATE
    PLAYER_END = EUnitFields.UNIT_END + 0x2BC                                     // 0x34C
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
    GAMEOBJECT_PADDING = EObjectFields.OBJECT_END + 0xF,                          // 0x015 - Size: 1 - Type: INT - Flags: NONE
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
