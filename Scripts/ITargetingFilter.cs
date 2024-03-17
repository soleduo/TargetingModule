using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace soleduo.JRPGCore.Targeting
{
    public interface ITargetingFilter<T>
    {
        bool TryGetTargets(out IEnumerable<T> validTargets);
    }

    public interface ITargetingFilter : ITargetingFilter<GameObject>
    {

    }
 
}
