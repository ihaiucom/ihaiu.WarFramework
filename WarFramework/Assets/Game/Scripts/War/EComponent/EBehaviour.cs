using UnityEngine;
using System.Collections;
using System;

namespace Games.Wars
{
	/** 实体行为 */
	public class EBehaviour : PoolItem<EBehaviour>, IEComponent, IPause
	{
		#region IScript
		/** 释放 */
		override public void CRelease()
		{
			base.CRelease ();

			ctl = null;
		}
		#endregion





		#region IEComponent
		public ECtl ctl { get; set;}

		/** Ctl添加了该组件 */
		virtual public void OnAddCtl (ECtl ctl)
		{
			this.ctl = ctl;
		}

		/** Ctl移除了该组件 */
		virtual public void OnRemoveCtl ()
		{
			Despawned ();
		}
		#endregion




		#region IPause
		/** 暂停 */
		virtual public void Pause()
		{
		}


		/** 继续 */
		virtual public void Resume()
		{
		}
		#endregion

	}
}
