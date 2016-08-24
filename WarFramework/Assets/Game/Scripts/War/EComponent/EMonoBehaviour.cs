using UnityEngine;
using System.Collections;
using System;
using Ihaius;

namespace Games.Wars
{
	/** 实体行为 */
    public class EMonoBehaviour : MonoBehaviour, IScript, IEComponent, IPause
	{



        #region IScript
        /** 重置 */
        virtual public void CReset()
        {
        }

        /** 释放 */
        virtual public void CRelease()
        {
			this.ctl = null;
        }

        /** 销毁 */
        virtual public void CDealloc()
        {
			CRelease ();
        }
        #endregion





        #region PrefabPool
		/** PrefabPool--设置为使用状态消息 */
		virtual public void OnSpawned(PrefabPool pool)
		{
			CReset ();
		}


		/** PrefabPool--设置为闲置状态消息 */
		virtual public void OnDespawned(PrefabPool pool)
		{
			CRelease ();
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




		#region MonoBehaviour
		virtual protected void OnDestroy()
		{
			CDealloc ();
		}
		#endregion
	}
}
