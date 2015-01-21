using Microsoft.Practices.EnterpriseLibrary.Caching;


public class RefreshCache : ICacheItemRefreshAction
{
    public void Refresh(string removedKey, object expiredValue, CacheItemRemovedReason removalReason)
    {
        CacheFactory.GetCacheManager("CacheContent").Flush();
    }
}