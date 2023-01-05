using DungeonCrawler.Forms_Design;

namespace DungeonCrawler
{
    public static class RoomBuilder
    {
        public static Room CellRoom()
        {
            string cellRoomDescription = "You wake up in a small, dark cell. The air is musty and there is a faint smell of mold. " +
                                         "The walls are made of rough stone, and there are iron bars on the door. " +
                                         "You see a small cot in the corner of the room, and a bucket in the opposite corner. " +
                                         "There is a pile of moldy straw on the floor.";

            Weapon rustyChain = new Weapon("Rusty Chain", 1, 1, 3, 0);

            Attack attack = new Attack("Break down the door", "Break door", "You showed that door who's boss!");
            TakeItem takeItem = new TakeItem("Pull the chain off the wall", "Pull Chain", "You manage to pull the chain of the wall. At least it's something.", rustyChain, false);
            Search search = new Search("Search for a way out", "Search", "There's a rusty chain on the wall, better than no weapon at all." +
                                                                         "\n[HINT] Remember to equip your items in your inventory list!", 5);

            return new Room(cellRoomDescription, EnemyBuilder.CreateDoor(), attack, takeItem, search, null);
        }
        public static Room RitualChamberRoom()
        {
            string ritualChamberDescription = "As you push open the heavy iron door, you enter a large, dimly-lit chamber. " +
                                              "The walls are adorned with strange symbols and sigils. " +
                                              "There is a raised platform in the center of the room, where there lays a body clad in red robes. " +
                                              "It seems that you have stumbled upon some kind of forbidden ritual site.";

            Item smallSpellBook = new Item("Small spell book", 15);
            TakeItem takeItem = new TakeItem("Search the body for anything useful", "Search Body", "You find a small spell book, not that you can use it, " +
                                                                                                   "but it's worth something to the right person", smallSpellBook, true);

            return new Room(ritualChamberDescription, null, null, takeItem, null, null);
        }
        public static Room SecondCell()
        {
            string dungeonRoomDescription = "You enter a small, cramped room. The walls are made of rough stone, and there is a faint smell of mold. " +
                                            "There is a small table in the corner, with a few rusty chains and shackles scattered on top. " +
                                            "There is a pile of straw on the floor, and you can hear the faint sound of dripping water. " +
                                            "It looks like this room was once used for imprisoning people. Nothing to find here.";

            return new Room(dungeonRoomDescription, null, null, null, null, null);
        }
        public static Room PeacefulFountainRoom()
        {
            string healingRoomDescription = "You enter a small room with a calming atmosphere. There is a fountain in the center of the room, " +
                                            "and the sound of running water fills the air. You feel a sense of peace wash over you. " +
                                            "There is a small table to the side of the room, with a healing potion on it.";

            Potion healingPotion = new Potion("Healing potion", 10, 5, 10);
            TakeItem takeHealingPotion = new TakeItem("Take a healing potion", "Take potion", "You take a healing potion.", healingPotion, true);

            return new Room(healingRoomDescription, null, null, takeHealingPotion, null, null);
        }
        public static Room AbandonedLibrary()
        {
            string libraryDescription = "As you enter the abandoned library, you are greeted by the musty smell of old books. " +
                                        "Dust covers the shelves and the only light comes from a few cracks in the walls. " +
                                        "You see a desk with a few scattered papers and a chair pushed to the side. " +
                                        "On the shelves, you spot a few old tomes, their spines falling apart.";

            Accessory goldenAmulet = new Accessory("Golden Amulet", 50, 0, 1, 2);
            TakeItem takeItem = new TakeItem("Take the Amulet from the desk", "Take Amulet", "You take the amulet from the desk.", goldenAmulet , false);
            Search search = new Search("Search the desk for anything useful", "Search Desk", "In the desk you find an enchanted golden amulet, you can equip it to increase your stats.", 1);

            return new Room(libraryDescription, null, null, takeItem, search, null);
        }
        public static Room ArmoryLockedChestRoom()
        {
            string description = "You enter a room that must at some point have been an armory. There are racks that have held weapons long ago, but now they are bare. " +
                                 "You see a large chest in the corner, and a small keyhole on the front. " +
                                 "It looks like the chest is locked, and you'll need a key to open it.";

            Weapon sword = new Weapon("Longsword",20, 1, 6, 1);
            TakeItem takeSword = new TakeItem("Open the treasure", "Open Chest", "Within the chest you find a Longsword!", sword, false);
            Search searchForKey = new Search("Search for a key", "Search", "You found a small iron key", 18);

            return new Room(description, null, null, takeSword, searchForKey, null);
        }
        public static Room CryptRoom()
        {
            string description = "You enter a creepy crypt. There are rows of stone tombs, and cobwebs everywhere. " +
                                 "There is a faint smell of decay in the air. You see a large stone sarcophagus in the center of the room, " +
                                 "and standing behind it... is an undead knight!";

            Enemy undeadKnight = EnemyBuilder.CreateUndeadKnight();
            Attack attackKnight = new Attack("Fight the undead knight", "Attack", "You attack the undead knight!");

            return new Room(description, undeadKnight, attackKnight, null, null, null);
        }
        public static Room StudyRoom()
        {
            string studyRoomDescription = "You enter a small study adjacent to the library. The walls are all lined with old tomes, other than a small desk along the western wall. " +
                                          "There are many ancient books here, maybe one of them can be of use or value?";

            Accessory ancientBracer = new Accessory("Ancient Bracer", 30, 1, 2, 0);
            TakeItem examineBook = new TakeItem("Examine the book", "Examine", "As you reach for the book, you feel a strange energy coursing through your body. " +
                                                                               "You pick up the book, and a bright light envelops you. " +
                                                                               "When the light fades, you find yourself holding a strange bracer in your hands.", ancientBracer, false);

            Search search = new Search("Search the room for a useful book", "Search", "One book stands out, it doesn't look as aged as the others, it looks brand new.", 16);

            return new Room(studyRoomDescription, null, null, examineBook, search, null);
        }
        public static Room MimicRoom()
        {
            string mimicRoomDescription = "As you enter the room, you see a chest in the corner. " +
                                          "You approach it, hoping to find some valuable treasure inside. " +
                                          "As you reach for the lid, it suddenly springs open you see a mass of sharp teeth as the chest tries to bite you!";

            Enemy mimic = EnemyBuilder.CreateMimic();
            Attack attack = new Attack("Fight the mimic", "Fight", "You swing your weapon at the mimic!");

            return new Room(mimicRoomDescription, mimic, attack, null, null, null);
        }
        public static Room GelatinousCubeRoom()
        {
            string gelatinousCubeRoomDescription = "You find yourself in a damp, musty room. The stone walls are cold to the touch and the floor is slick with moisture. " +
                                                   "There is a faint glow coming from a crack in the wall, illuminating the room just enough for you to see your surroundings. " +
                                                   "You see something move, a massive, green, cube of slime. " +
                                                   "Within it floats skeletal parts and old equipment, proof of other adventurers having perished against the cube. ";

            Enemy gelatinousCube = EnemyBuilder.CreateGelatinousCube();
            Attack attack = new Attack("Attack the cube!", "Attack", "You fought against the cube");

            return new Room(gelatinousCubeRoomDescription, gelatinousCube, attack, null, null, null);
        }
        public static Room ArmourRoom()
        {
            string armourRoomDescription = "You enter a room filled with racks of armour. The room is dimly lit, and you can see a variety of different types of armour, in various states of disrepair. " +
                                           "You can see a suit of plate armour on the far wall, it looks to be in good condition. ";

            Armour plateArmour = new Armour("Plate Armour", 80, 4);
            TakeItem takeArmour = new TakeItem("Take the plate armour", "Take", "You take the plate armour, it can give you great protection", plateArmour, true);

            return new Room(armourRoomDescription, null, null, takeArmour, null, null);
        }
        public static Room GhostDiningRoom()
        {
            string ghostRoomDescription = "You enter what was once an opulent dining room. The walls are adorned with gold leaf and intricate frescoes, and the high ceiling is supported by marble columns. " +
                                          "However, upon closer inspection, you realize that the room has been abandoned for many years. " +
                                          "Cobwebs hang from the chandeliers and the once-fine furnishings are now covered in a thick layer of dust. " +
                                          "The grand table at the center of the room is still set with silverware and fine china, but the plates are empty and the crystal glasses are cracked. " +
                                          "It's clear that this room has not seen use in a long time. " +
                                          "You can see a faint glow coming from the far end of the table.";

            Enemy ghost = EnemyBuilder.CreateGhost();
            Attack attackGlow = new Attack("Investigate the glowing light", "Investigate", "You cautiously approach the source of the glow and find a strange, glowing orb. " +
                                                                                           "As you reach for it, the orb suddenly explodes and a ghostly figure appears before you!");

            return new Room(ghostRoomDescription, ghost, attackGlow, null, null, null);
        }
        public static Room AlchemicalRoom()
        {
            string alchemicalRoomDescription = "When you enter this room you immediately sense a strong smell, a smell of chemicals and herbs. " +
                                               "The room is lined with shelves of bottles upon bottles, all of different colours and different labels " +
                                               "There is a small table with aged papers and a set of alchemical glassware. " +
                                               "Upon it sits a large corked bottle, with complicated geometrics design. " +
                                               "You recognise this as a greater healing potion, this can bring you back from the brink, sould you need it.";

            Potion healthPotion = new Potion("Greater Healing Potion", 50, 14, 24);
            TakeItem takePotion = new TakeItem("Take the potion", "Take", "You take the Greater Health Potion", healthPotion, true);

            return new Room(alchemicalRoomDescription, null, null, takePotion, null, null);
        }
        public static Room FinalBossRoom()
        {
            string description = "This room is opulent and expensive-looking, but it also looks completely brand new. " +
                                 "At the end of the room, there is an open door, behind it you can see forests and an open sky. It's the way out. " +
                                 "As you enter, you are greeted by a figure in flowing purple robes. " +
                                 "In the robes you can see a starry sky, moving. The robes seem to be supremely magical. " +
                                 "You suddenly remember; it's the evil wizard who has been terrorizing the kingdom. " +
                                 "It's because of him you were imprisoned here. " +
                                 "He sneers at you and brandishes his staff, ready to do battle.";

            Weapon wizardStaff = new Weapon("Wizard's Staff", 5000, 4, 8, 0);
            Enemy finalBoss = new Enemy("Evil Wizard", 40, 5, wizardStaff, 16, "The evil wizard shoots lightning from his staff!");

            Attack attack = new Attack("Attack the wizard", "Attack", "You fight the wizard for your one chance to escape");

            return new Room(description, finalBoss, attack, null, null, null);
        }
        public static Room EscapeRoom()
        {
            string description = "As you walk through the open door, the sunlight pours in, blinding you for a moment. " +
                                 "When your eyes adjust, you see the vast forests and open sky stretching out before you. " +
                                 "You have finally escaped the dark and dreary dungeon, and emerged victorious. " +
                                 "The evil wizard lies defeated at your feet, his reign of terror finally brought to an end by your bravery and determination. " +
                                 "You take a deep breath, feeling a sense of relief wash over you as you step out into the freedom of the outside world.";

            Escape escape = new Escape("Escape the dungeon","Escape", "You managed to escape the dungeon!");

            return new Room(description, null, null, null, null, escape);
        }
    }
}