﻿using Xunit;
using ZabbixApi;

namespace ZabbixApiTests.Integration
{
    public class ScreenServiceIntegrationTest
    {
        [Fact]
        public void MustGetAny()
        {
            using (IContext context = new Context())
            {
                var result = context.Screens.Get();
                Assert.NotNull(result);
                Assert.NotEmpty(result);
            }
        }
    }
}
