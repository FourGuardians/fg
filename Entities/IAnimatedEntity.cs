using UnityEngine;

namespace Fg.Entities
{
    public interface IAnimatedEntity
    {
        public Animator Animator { get; }

        public bool AnimIdle
        {
            get
            {
                return Animator.GetBool("Idle");
            }

            set
            {
                Animator.SetBool("Idle", value);
            }
        }

        public int AnimDirection
        {
            get
            {
                return Animator.GetInteger("Direction");
            }

            set
            {
                Animator.SetInteger("Direction", value);
            }
        }
    }
}