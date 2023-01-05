namespace DungeonCrawler
{
    /// <summary>
    /// Static class which contains methods defining enemies to be used in the dungeon.
    /// </summary>
    public static class EnemyBuilder
    {
        /// <summary>
        /// Creates a door enemy
        /// </summary>
        /// <returns>The door</returns>
        public static Enemy CreateDoor()
        {
            Weapon itsADoor = new Weapon("", 0, 1, 3, 0);
            return new Enemy("Door", 5, 0, itsADoor, 10, "You slip and hit your head against the door");
        }
        /// <summary>
        /// Creates an undead knight enemy
        /// </summary>
        /// <returns>The undead knight</returns>
        public static Enemy CreateUndeadKnight()
        {
            Weapon knightSword = new Weapon("Knight's Sword", 10, 2, 6, 0);
            return new Enemy("Undead Knight", 12, 2, knightSword, 13, "The Undead Knight swings and slashes you!");
        }
        /// <summary>
        /// Creates a mimic enemy
        /// </summary>
        /// <returns>The mimic</returns>
        public static Enemy CreateMimic()
        {
            Weapon mimicTeeth = new Weapon("Mimic Teeth", 0, 3, 5, 0);
            return new Enemy("Mimic", 10, 1, mimicTeeth, 8, "The mimic tries to bite you!");
        }
        /// <summary>
        /// Creates a gelatinous cube enemy
        /// </summary>
        /// <returns>The gelatinous cube</returns>
        public static Enemy CreateGelatinousCube()
        {
            Weapon gelatinousChomp = new Weapon("Gelatinous Cube", 0, 3, 5, 0);
            return new Enemy("Gelatinous Cube", 32, 2, gelatinousChomp, 12, "The gelatinous cube attempts to absorb you!");
        }
        /// <summary>
        /// Creates a ghost enemy
        /// </summary>
        /// <returns>The ghost</returns>
        public static Enemy CreateGhost()
        {
            Weapon ghostTouch = new Weapon("Ghostly Touch", 0, 2, 5, 0);
            return new Enemy("Ghost", 15, 2, ghostTouch, 18, "The ghost reaches out and tries to strike you!");
        }
    }
}