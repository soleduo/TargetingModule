using UnityEngine;

namespace soleduo.JRPGCore.Targeting
{
    public abstract class BaseTargetingSelector<T> : ITargetingSelector<T>
    {
        public abstract bool TrySelectTarget(out T target);
    }

    public abstract class BaseTargetingSelector : BaseTargetingSelector<GameObject>
    {

    }
}
