using UnityEngine;

namespace soleduo.JRPGCore.Targeting
{
    public interface ITargetingSelector<T>
    {
        bool TrySelectTarget(out T target);
    }

    public interface ITargetingSelector : ITargetingSelector<GameObject>
    {
        
    }
}
