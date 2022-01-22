using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public enum tileType { Grass, Path, Wall }

[CreateAssetMenu]

public class TileData : ScriptableObject
{
   //unity의 tilemap에서 제공하는 기본 함수까지 사용하기 위해서 TileBase를 사용함.
    public TileBase[] tiles;

    public bool movable;
    public tileType type;
}