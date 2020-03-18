using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface GhostInterface : GameObjectInterface
{
    GhostType ghostType { get; }

    /// <summary>
    /// Creates the movement pattern for the Ghost
    /// </summary>
    void MovementPattern();
}