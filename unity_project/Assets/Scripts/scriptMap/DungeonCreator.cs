using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int dungeonWidth, dungeonLength;
    public int roomWidthMin, roomLengthMax;
    public int maxIterations;
    public int corridorWidth;

    // Start is called before the first frame update
    void Start()
    {
        CreateDungeon();
    }

    // Update is called once per frame
    void Update()
    {
        DugeonGenerator generator = new DugeonGenerator(dungeonWidth, dungeonLength);
        var listeOfRooms = generator.CalculateRooms(maxIterations,roomWidthMin,roomLengthMax);

    }
}
