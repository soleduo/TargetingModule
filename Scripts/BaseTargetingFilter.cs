using System.Collections.Generic;
using UnityEngine;

namespace soleduo.JRPGCore.Targeting
{
    public abstract class BaseTargetingFilter<T> : ITargetingFilter<T>
    {
        public abstract bool TryGetTargets(out IEnumerable<T> validTargets);
    }

    /// <summary>
    /// Base Targeting Filter constructor shortcut
    /// </summary>
    public abstract class BaseTargetingFilter : BaseTargetingSelector<GameObject>
    {

    }
}
