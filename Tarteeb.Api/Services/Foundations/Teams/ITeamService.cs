﻿//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//=================================

namespace Tarteeb.Api.Services.Foundations.Teams
{
    public interface ITeamService
    {
        ValueTask<Team> AddTeamAsync(Team team);
        IQueryable<Team> RetrieveAllTeams();
    }
}