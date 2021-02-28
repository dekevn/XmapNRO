﻿using System.Collections.Generic;

namespace Assembly_CSharp.Xmap
{
    public class LinkMaps : Dictionary<int, List<MapNext>>
    {
    }

    public struct MapNext
    {
        public int MapID;

        public TypeMapNext Type;

        public int[] Info;

        public MapNext(int mapID, TypeMapNext type, int[] info)
        {
            MapID = mapID;
            Type = type;
            Info = info;
        }
    }

    public struct GroupMap
    {
        public string NameGroup;

        public List<int> IdMaps;

        public GroupMap(string nameGroup, List<int> idMaps)
        {
            NameGroup = nameGroup;
            IdMaps = idMaps;
        }
    }

    public enum TypeMapNext
    {
        AutoWaypoint,
        NpcMenu,
        NpcPanel,
        Position,
        Capsual
    }
}