using UnityEngine;
using System.Collections;
using Ihaius;


namespace Games.Wars
{
	/** 单位代理 (管理美术表现) */
    public class UnitAgent : EMonoBehaviour 
	{
		PrefabPool prefabPool;
		#region PrefabPool
		/** PrefabPool--设置为使用状态消息 */
		public override void OnSpawned (PrefabPool pool)
		{
			this.prefabPool = pool;
			base.OnSpawned (pool);
		}


		#endregion


		#region IEComponent
		/** Ctl移除了该组件 */
		public override void OnRemoveCtl ()
		{
			base.OnRemoveCtl ();

			if (this.prefabPool != null) 
			{
				this.prefabPool.DespawnInstance (transform);
			}
			else 
			{
				Destroy (gameObject);
			}
		}
		#endregion

	}
}
