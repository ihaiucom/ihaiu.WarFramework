using UnityEngine;
using System.Collections;
using System;


namespace Games.Wars
{
	/** 实体数据 */
    public class EData : PoolItem<EData>, IEComponent 
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
			CRelease ();
		}
		#endregion


	}
}
