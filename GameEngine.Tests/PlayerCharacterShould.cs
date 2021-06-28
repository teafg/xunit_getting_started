using System;
using System.Net.Http.Headers;
using Xunit;

namespace GameEngine.Tests
{
    public class PlayerCharacterShould
    {
        [Fact]
        public void BeInexperiencedWhenNew()
        {
            var sut = new PlayerCharacter();

            Assert.True(sut.IsNoob);
        }

        [Fact]
        public void CalculateFullName()
        {
            var sut = new PlayerCharacter();
            sut.FirstName = "Sarah";
            sut.LastName = "Parker";

            Assert.Equal("Sarah Parker", sut.FullName);
        }
    }
}
