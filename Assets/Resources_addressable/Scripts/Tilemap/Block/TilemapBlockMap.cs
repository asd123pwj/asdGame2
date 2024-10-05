using System.Collections.Generic;
using UnityEngine;


public class TilemapBlockMap: BaseClass{
    string[,] map;
    TilemapBlock block;
    
    // public Vector3Int size => _GCfg._sysCfg.TMap_tiles_per_block;

    // public int initStage;

    public TilemapBlockMap(TilemapBlock block){
        this.block = block;
        map = new string[block.size.x, block.size.y];
    }


    // public string[,] _get_map() => map;
    public string _get(int x, int y) {
        if (x < block.size.x && y < block.size.y && x >= 0 && y >= 0)
            return map[x, y];
        else if (x >= block.size.x){
            TilemapBlock block_right = block.around.right;
            return block_right.isExist ? block_right.map._get(x - block.size.x, y) : _GCfg._NotLoaded_tile;
        }
        else if (y >= block.size.y){
            TilemapBlock block_up = block.around.up;
            return block_up.isExist ? block_up.map._get(x, y - block.size.y) : _GCfg._NotLoaded_tile;
        }
        else if (x < 0){
            TilemapBlock block_left = block.around.left;
            return block_left.isExist ? block_left.map._get(x + block.size.x, y) : _GCfg._NotLoaded_tile;
        }
        else if (y < 0){
            TilemapBlock block_down = block.around.down;
            return block_down.isExist ? block_down.map._get(x, y - block.size.y) : _GCfg._NotLoaded_tile;
        }
        return _GCfg._NotLoaded_tile;
    }
    public string _get(Vector3Int pos) => map[pos.x, pos.y];

    public void _set(Dictionary<Vector3Int, string> map){
        foreach (var pair in map){
            _set(pair.Key, pair.Value);
        }
    } 
    public void _set(Vector3Int pos, string tile_ID){
        map[pos.x, pos.y] = tile_ID;
    } 
    public void _set(int x, int y, string tile_ID){
        map[x, y] = tile_ID;
    } 


    
}