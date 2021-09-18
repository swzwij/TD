using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    [SerializeField]
    private bool _isBuildable;

    public bool GetisBuildable()
    {
        return _isBuildable;
    }
}
