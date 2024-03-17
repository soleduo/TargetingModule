using System.Collections.Generic;
using UnityEngine;

namespace soleduo.JRPGCore.Targeting
{
    public abstract class BaseTargetingModule<T> : ITargetingSweeper<T>, ITargetingFilter<T>, ITargetingSelector<T>
    {
        public abstract bool TryGetAllAvalaibleTargetsInRange(out IEnumerable<T> availableTargets);
        public abstract bool TryGetTargets(out IEnumerable<T> validTargets);
        public abstract bool TrySelectTarget(out T target);
    }

    public abstract class BaseTargetingModule : BaseTargetingModule<GameObject>
    {

    }
}
