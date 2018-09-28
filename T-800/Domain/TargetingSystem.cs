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
            if (EnemyTarget == true)
            {
                //Delete target from target list
            }
            else
            {
                //Return to menu
            }

            if (FriendlyTarget == true)
            {
                //Move friendly target to saved list
            }
            else
            {
                //Report status on friendly target
            }
        }
    }
}
