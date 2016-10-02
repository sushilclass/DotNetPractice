using CSharp1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


class Program
{

    static List<Room> getRoomList()
    {
        Random random = new Random();
        List<Room> rooms = new List<Room>();
        List<string> roomTypes = new List<string>();
        roomTypes.Add("General");
        roomTypes.Add("Super");
        roomTypes.Add("Executive");

        for (int i = 1; i <= 100; i++)
        {
            int rendomRoomTypeIndex = random.Next(roomTypes.Count());
            Room room = new Room();
            room.roomNo = 1;
            room.roomType = roomTypes.ElementAt(rendomRoomTypeIndex);
            rooms.Add(room);
        }
        return rooms;
    }


    //static void Main(string[] args)
    //{

    //    List<Room> rooms = getRoomList();
    //    Dictionary<string, int> roomTypeSummery = getRoomTypeSummery(rooms);

    //    printRoomTypeSummery(roomTypeSummery);
    //}

    private static Dictionary<string, int> getRoomTypeSummery(List<Room> rooms)
    {
        Dictionary<string, int> roomTypeSummery = new Dictionary<string, int>();
        foreach (Room room in rooms)
        {
            int roomCount = 0;
            if (!roomTypeSummery.ContainsKey(room.roomType))
            {
                roomTypeSummery.Add(room.roomType, ++roomCount);
            }
            else
            {

                int roomCountLatest = roomTypeSummery[room.roomType] + 1;
                roomTypeSummery.Remove(room.roomType);
                roomTypeSummery.Add(room.roomType, roomCountLatest);

            }
        }

        return roomTypeSummery;
    }

    private static void printRoomTypeSummery(Dictionary<string, int> roomTypeSummery)
    {
        foreach (string roomType in roomTypeSummery.Keys)
        {
            Console.WriteLine("Room Type : {0} Total Room : {1}", roomType, roomTypeSummery[roomType]);
        }
    }
}









