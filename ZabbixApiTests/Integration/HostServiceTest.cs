﻿using Xunit;
using ZabbixApi;

namespace ZabbixApiTests.Integration
{
    public class HostServiceTest
    {
        [Fact]
        public void MustGetAny()
        {
            using (IContext context = new Context())
            {
                var result = context.Hosts.Get();
                Assert.NotNull(result);
                Assert.NotEmpty(result);
            }
        }
    }
}
