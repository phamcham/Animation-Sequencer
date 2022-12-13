#if DOTWEEN_ENABLED
using System;
using UnityEngine;

namespace BrunoMikoski.AnimationSequencer
{
    [Serializable]
    public sealed class AnchoredPositionMoveToRectTransformPositionDOTweenActionBase : AnchoredPositionMoveDOTweenActionBase
    {
        [SerializeField]
        private RectTransform targetRectTransform;
        public RectTransform RectTransform
        {
            get => targetRectTransform;
            set => targetRectTransform = value;
        }

        public override string DisplayName => "Move to RectTransform Anchored Position";

        protected override Vector2 GetPosition()
        {
            return targetRectTransform.anchoredPosition;
        }
    }
}
#endif
