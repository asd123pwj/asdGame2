using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using Cysharp.Threading.Tasks;
using Unity.VectorGraphics;


public class MaterialSystem: BaseClass{
    public ObjectManager _obj;
    public UIPrefabManager _UIPfb;
    public UISpriteManager _UISpr;
    public TileManager _tile;
    public MaterialManager _mat;
    public MeshManager _mesh;
    public PhysicsMaterialManager _phyMat;
    public TerrainManager _terrain;

    public override void _init(){
        _obj = new();
        _UIPfb = new();
        _UISpr = new();
        _tile = new();
        _mat = new();
        _mesh = new();
        _phyMat = new();
        _terrain = new();
    }
    
    public bool _check_all_info_initDone(){
        if (!_initDone) return false;
        if (!_obj._check_info_initDone()) return false;
        if (!_UIPfb._check_info_initDone()) return false;
        if (!_UISpr._check_info_initDone()) return false;
        if (!_tile._check_info_initDone()) return false;
        if (!_mat._check_info_initDone()) return false;
        if (!_mesh._check_info_initDone()) return false;
        if (!_phyMat._check_info_initDone()) return false;
        if (!_terrain._check_info_initDone()) return false;
        return true;
    }


}
