﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Xunit;

namespace FunkyBDD.SxS.Framework.Specs
{
    [Binding, Scope(Feature = "API testing")]
    public sealed class APISteps
    {
        private API call;

        [When(@"I request user (.*) of the dummy api")]
        public void WhenIRequestUserOfTheDummyApi(int id)
        {
            call = new API($"https://reqres.in/api/users/{id}");
        }

        [Then(@"the response status should be '(.*)'")]
        public void ThenTheResponseStatusShouldBe(string status)
        {
            Assert.Equal(status, call.Status);
        }

    }
}