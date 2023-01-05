using System.Collections.Generic;
using System.Linq;

namespace DungeonCrawler
{
    /// <summary>
    /// A class which defines a Dungeon as the playscape.
    /// Contains a list of all the rooms, as well as currentRoom variable, the room the player is currently in
    /// </summary>
    internal class Dungeon
    {
        private LinkedList<Room> roomList = new LinkedList<Room>(); // The List of Room objects, the entire playspace
        private Room currentRoom;                                   // The Room the player is currently in

        /// <summary>
        /// Method which creates the Default dungeon through code, as well as sets the starting room to be the currentRoom
        /// </summary>
        public void AddDefaultDungeon()
        {
            Room cell = RoomBuilder.CellRoom();
            roomList.AddFirst(cell);
            currentRoom = roomList.First();

            Room ritualChamber = RoomBuilder.RitualChamberRoom();
            ritualChamber.South = cell;
            cell.North = ritualChamber;
            roomList.AddLast(ritualChamber);

            Room secondCell = RoomBuilder.SecondCell();
            secondCell.South = ritualChamber;
            ritualChamber.North = secondCell;
            roomList.AddLast(secondCell);

            Room peacefulFountainRoom = RoomBuilder.PeacefulFountainRoom();
            peacefulFountainRoom.West = ritualChamber;
            ritualChamber.East = peacefulFountainRoom;
            roomList.AddLast(peacefulFountainRoom);

            Room abandonedLibrary = RoomBuilder.AbandonedLibrary();
            abandonedLibrary.South = peacefulFountainRoom;
            peacefulFountainRoom.North = abandonedLibrary;
            roomList.AddLast(abandonedLibrary);

            Room studyRoom = RoomBuilder.StudyRoom();
            studyRoom.South = abandonedLibrary;
            abandonedLibrary.North = studyRoom;
            roomList.AddLast(studyRoom);

            Room mimicRoom = RoomBuilder.MimicRoom();
            mimicRoom.West = abandonedLibrary;
            abandonedLibrary.East = mimicRoom;
            roomList.AddLast(mimicRoom);

            Room armoryRoom = RoomBuilder.ArmoryLockedChestRoom();
            armoryRoom.East = ritualChamber;
            ritualChamber.West = armoryRoom;
            roomList.AddLast(armoryRoom);

            Room cryptRoom = RoomBuilder.CryptRoom();
            cryptRoom.South = armoryRoom;
            armoryRoom.North = cryptRoom;
            roomList.AddLast(cryptRoom);

            Room gelatinousCubeRoom = RoomBuilder.GelatinousCubeRoom();
            gelatinousCubeRoom.South = cryptRoom;
            cryptRoom.North = gelatinousCubeRoom;
            studyRoom.West = gelatinousCubeRoom;
            gelatinousCubeRoom.East = studyRoom;
            roomList.AddLast(gelatinousCubeRoom);

            Room armourRoom = RoomBuilder.ArmourRoom();
            armourRoom.South = gelatinousCubeRoom;
            gelatinousCubeRoom.North = armourRoom;
            roomList.AddLast(armourRoom);

            Room ghostDiningRoom = RoomBuilder.GhostDiningRoom();
            ghostDiningRoom.East = armourRoom;
            armourRoom.West = ghostDiningRoom;
            roomList.AddLast(ghostDiningRoom);

            Room alchemicalRoom = RoomBuilder.AlchemicalRoom();
            alchemicalRoom.East = ghostDiningRoom;
            ghostDiningRoom.West = alchemicalRoom;
            roomList.AddLast(alchemicalRoom);

            Room finalBossRoom = RoomBuilder.FinalBossRoom();
            finalBossRoom.South = ghostDiningRoom;
            ghostDiningRoom.North = finalBossRoom;
            roomList.AddLast(finalBossRoom);

            Room escapeRoom = RoomBuilder.EscapeRoom();
            escapeRoom.South = finalBossRoom;
            finalBossRoom.North = escapeRoom;
            roomList.AddLast(escapeRoom);
        }
        /// <summary>
        /// Getter and setter for the currentRoom
        /// </summary>
        public Room CurrentRoom
        {
            get { return currentRoom; }
            set { currentRoom = value; }
        }
    }
}