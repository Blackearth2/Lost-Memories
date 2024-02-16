using System;
using System.Collections.Generic;
using UnityEngine;

public class DugeonGenerator
{
    RoomNode rootNode;
    List<RoomNode> allSPaceNodes = new List<RoomNode>();  
    private int dungeonWidth;
    private int dungeonLength;
    // Start is called before the first frame update

    public DugeonGenerator(int dungeonWidth, int dungeonLength)
    {
        this.dungeonWidth = dungeonWidth;
        this.dungeonLength = dungeonLength;

    }


    internal object CalculateRooms(int maxIterations,int roomWidthMin,int roomLengthMax)
    {
        throw new NotImplementedException();

    }
}