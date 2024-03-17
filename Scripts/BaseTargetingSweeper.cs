using System.Collections.Generic;
using UnityEngine;

namespace soleduo.JRPGCore.Targeting
{
    public abstract class BaseTargetingSweeper<T> : ITargetingSweeper<T>
    {
        public abstract bool TryGetAllAvalaibleTargetsInRange(out IEnumerable<T> availableTargets);
    }

    public abstract class BaseTargetingSweeper : BaseTargetingSweeper<GameObject>
    {

    }
}
