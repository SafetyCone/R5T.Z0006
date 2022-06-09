using System;


namespace R5T.Z0006
{
	public class NamespacedTypeNames : INamespacedTypeNames
	{
		#region Infrastructure

	    public static NamespacedTypeNames Instance { get; } = new();

	    private NamespacedTypeNames()
	    {
	    }

	    #endregion
	}
}