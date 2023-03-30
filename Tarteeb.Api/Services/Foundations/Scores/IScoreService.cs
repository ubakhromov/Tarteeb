//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//=================================

using System;
using System.Linq;
using System.Threading.Tasks;
using Tarteeb.Api.Models.Foundations.Scores;

namespace Tarteeb.Api.Services.Foundations.Scores
{
    public interface IScoreService
    {
        IQueryable<Score> RetrieveAllScores();
        ValueTask<Score> RemoveScoreByIdAsync(Guid scoreId);
    }
}
