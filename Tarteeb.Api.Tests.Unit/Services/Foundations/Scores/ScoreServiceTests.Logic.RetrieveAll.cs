//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//=================================

using FluentAssertions;
using Moq;
using System.Linq;
using Tarteeb.Api.Models.Foundations.Scores;
using Xunit;

namespace Tarteeb.Api.Tests.Unit.Services.Foundations.Scores
{
    public partial class ScoreServiceTests
    {
        [Fact]
        public void ShouldRetrieveAllScores()
        {
            // given
            IQueryable<Score> randomScores = CreateRandomScores();
            IQueryable<Score> storageScores = randomScores;
            IQueryable<Score> expectedScores = storageScores;

            this.storageBrokerMock.Setup(broker =>
                broker.SelectAllScores()).Returns(storageScores);

            // when
            IQueryable<Score> actualScore =
                this.scoreService.RetrieveAllScores();

            // then
            actualScore.Should().BeEquivalentTo(expectedScores);

            this.storageBrokerMock.Verify(broker =>
                broker.SelectAllScores(), Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();
            this.loggingBrokerMock.VerifyNoOtherCalls();
            this.dateTimeBrokerMock.VerifyNoOtherCalls();
        }
    }
}
