using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp1
{
    class ListSplitUtility
    {
        static List<Room> getRoomList()
        {
            Random random = new Random();
            List<Room> rooms = new List<Room>();
            List<string> roomTypes = new List<string>();
            roomTypes.Add("General");
            roomTypes.Add("Super");
            roomTypes.Add("Executive");

            for (int i = 1; i <= 50; i++)
            {
                int rendomRoomTypeIndex = random.Next(roomTypes.Count());
                Room room = new Room();
                room.roomNo = 1;
                room.roomType = roomTypes.ElementAt(rendomRoomTypeIndex);
                rooms.Add(room);
            }
            return rooms;
        }


        static List<List<T>> SplitedList<T>(List<T> completelist, int maxItemInOneList)
        {
            List<List<T>> splitedList = new List<List<T>>();
            for (int i = 0; i < completelist.Count; i = i + maxItemInOneList)
            {
                int fromIndex = i;
                int toIndex = Math.Min( maxItemInOneList , completelist.Count - fromIndex);
                Console.WriteLine("FromIndex:{0},ToIndex:{1}", fromIndex, toIndex);

                List<T> subList = completelist.GetRange(fromIndex, toIndex);
                    splitedList.Add(subList);
                
            }
            return splitedList;
        }
        public static void Main(string[] args)
        {
            List<string> numberslist = new List<string>();

            for(int i=1;i<=100;i++)
            {
                numberslist.Add(i.ToString());
            }

            List<List<Room>> splitedList = SplitedList(getRoomList(), 7);
            Console.WriteLine("Total Split Room List Size : {0}", splitedList.Count);

            List<List<string>> splitedList2 = SplitedList(numberslist, 7);
            Console.WriteLine("Total Split String List Size : {0}", splitedList2.Count);
        }
    }


}
