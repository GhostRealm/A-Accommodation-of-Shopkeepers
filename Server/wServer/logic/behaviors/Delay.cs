﻿#region

using wServer.realm;

#endregion

namespace wServer.logic.behaviors
{
    // replacement for simple timed transition in sequence
    class Delay : CycleBehavior
    {
        // State storage: time

        readonly Behavior behavior;
        readonly int period;

        public Delay(int period, Behavior behavior)
        {
            this.behavior = behavior;
            this.period = period;
        }

        protected override void OnStateEntry(Entity host, RealmTime time, ref object state)
        {
            behavior.OnStateEntry(host, time);
            state = period;
        }

        protected override void TickCore(Entity host, RealmTime time, ref object state)
        {
            int period = (int)state;

            Status = CycleStatus.InProgress;

            period -= time.ElaspedMsDelta;
            if (period <= 0)
            {
                behavior.Tick(host, time);

                Status = CycleStatus.Completed;
                // ......- -
                if (behavior is Prioritize)
                    host.StateStorage[behavior] = -1;
            }

            state = period;
        }
    }
}