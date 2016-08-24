using UnityEngine;
using System.Collections;
namespace Games
{
	#if SCRIPTABLE
    public class BaseScript : ScriptableObject, IScript
	#else
    public class BaseScript : IScript
	#endif
	{
		/** 重置 */
		virtual public void CReset()
		{
		}
		
		/** 释放 */
		virtual public void CRelease()
		{
		}
		
		/** 销毁 */
		virtual public void CDealloc()
		{
			CRelease ();
		}
	}

}