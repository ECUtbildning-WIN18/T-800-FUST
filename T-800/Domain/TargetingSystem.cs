using System;
using System.Collections.Generic;
using System.Text;

namespace T_800.Domain
{
    class TargetingSystem
    {
        public bool EnemyTarget { get; set; }
        public bool FriendlyTarget { get; set; }
        public bool EliminateTarget { get; set; }
        public bool SaveTarget { get; set; }

        public TargetingSystem(bool enemyTarget, bool friendlyTarget, bool eliminateTarget, bool saveTarget)
        {
            EnemyTarget = enemyTarget;
            FriendlyTarget = friendlyTarget;
            EliminateTarget = eliminateTarget;
            SaveTarget = saveTarget;
        }

        public void Target()
        {
            if (EnemyTarget)
            {
                //Engage target if possible
            }
            else
            {
                //Return to home base for further instructions
            }

            if (FriendlyTarget)
            {
                //Make contact with friendly target
            }
            else
            {
                //Keep searching for friendly target
            }
        }
    }
}
