using UnityEngine;
using System.Collections;
using System;

namespace Games.Wars
{
	/** 实体组件接口 */
	public interface IEComponent 
	{
		ECtl ctl { get; set;}

		/** Ctl添加了该组件 */
		void OnAddCtl (ECtl ctl);

		/** Ctl移除了该组件 */
		void OnRemoveCtl ();
	}
}
