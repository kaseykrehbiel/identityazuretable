﻿// MIT License Copyright 2017 (c) David Melendez. All rights reserved. See License.txt in the project root for license information.

using System;
#if net45
using ElCamino.AspNet.Identity.AzureTable.Model;
#else
using ElCamino.AspNetCore.Identity.AzureTable.Model;
#endif
using Xunit;

namespace ElCamino.Web.Identity.AzureTable.Tests.ModelTests
{
    public class IdentityUserRoleTests
    {
        [Fact(DisplayName = "IdentityUserRoleGet_UserId")]
#if net45
        [Trait("Identity.Azure.Model", "")]
#else
        [Trait("IdentityCore.Azure.Model", "")]
#endif
        public void IdentityUserRoleGet_UserId()
        {
            var ur = new IdentityUserRole();
            ur.GenerateKeys();
            Assert.Equal(ur.PartitionKey, ur.UserId);
        }
    }
}
