using System.Collections.Generic;
using UnityEngine;

namespace soleduo.JRPGCore.Targeting
{
    public interface ITargetingSweeper<T>
    {
        bool TryGetAllAvalaibleTargetsInRange(out IEnumerable<T> availableTargets);
    }

    public interface ITargetingSweeper : ITargetingSweeper<GameObject>
    {

    }
}
