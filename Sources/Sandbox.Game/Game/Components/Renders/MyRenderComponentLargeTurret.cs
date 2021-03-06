﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sandbox.Game.Weapons;
using Sandbox.Common.Components;
using VRageMath;

namespace Sandbox.Game.Components
{
    class MyRenderComponentLargeTurret : MyRenderComponentCubeBlock
    {
        MyLargeTurretBase m_turretBase = null;
        #region overrides
        public override void OnAddedToContainer(MyComponentContainer container)
        {
            base.OnAddedToContainer(container);
            m_turretBase = Entity as MyLargeTurretBase;
        }
        public override void Draw()
        {
            if (m_turretBase.IsWorking)
            {
                base.Draw();

                if (m_turretBase.Barrel != null)                
                    m_turretBase.Barrel.Draw();
            }
        }


        #endregion
    }
}
