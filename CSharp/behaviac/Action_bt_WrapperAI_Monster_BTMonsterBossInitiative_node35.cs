﻿namespace behaviac
{
    using Assets.Scripts.GameLogic;

    internal class Action_bt_WrapperAI_Monster_BTMonsterBossInitiative_node35 : Action
    {
        protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
        {
            ((ObjAgent) pAgent).NotifyEventSysEnterCombat();
            return EBTStatus.BT_SUCCESS;
        }
    }
}
