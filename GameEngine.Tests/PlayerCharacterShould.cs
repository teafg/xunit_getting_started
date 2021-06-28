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

        [Fact]
        public void StartWithDefualtHealth()
        {
            var sut = new PlayerCharacter();

            Assert.Equal(100, sut.Health);
        }

        [Fact]
        public void IncreaseHealthAfterSleeping()
        {
            var sut = new PlayerCharacter();
            sut.Sleep();

            Assert.InRange(sut.Health, 101, 200);
        }

        [Fact]
        public void NotHaveNickNameByDefault()
        {
            var sut = new PlayerCharacter();

            Assert.Null(sut.Nickname);
        }

    }
}
